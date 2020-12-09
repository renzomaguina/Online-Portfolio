using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FlickerViewer
{
    public partial class FlickrViewerForm : Form
    {
        // Use your Flickr API key here
        private const string KEY = "ba2293c2502525c517debbd4f1a27189";

        // object used to invoke Flickr web service
        private static HttpClient flickrClient = new HttpClient();

        Task<string> flickrTask = null; // Task<string> that queries Flickr

        public FlickrViewerForm()
        {
            InitializeComponent();
        }

        // initiate asynchronous Flickr search query;
        // display results when query completes
        private async void searchButton_Click(object sender, EventArgs e)
        {
            // if flickrTask already running, prompt user
            if (flickrTask?.Status != TaskStatus.RanToCompletion)
            {
                var result = MessageBox.Show(
                    "Cancel the current Flickr search",
                    "Are you sure?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                // determines whether user wants to cancel prior search
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    flickrClient.CancelPendingRequests(); // cancel search
                }
            }

            // Flickr's web service URL for searches
            var flickrURL = "https://api.flickr.com/services/rest/?method=" +
                $"flickr.photos.search&api_key={KEY}&" +
                $"tags={inputTextBox.Text.Replace(" ", ",")}" +
                "&tag_mode=all&per_page=500&privacy_filter=1";

            imagesListBox.DataSource = null; // remove prior data source
            imagesListBox.Items.Clear(); // clear imageListBox
            pictureBox.Image = null; // clear pictureBox
            imagesListBox.Items.Add("Loading..."); // display Loading...

            // invoke Flickr web service to search Flickr with user's tags
            flickrTask = flickrClient.GetStringAsync(flickrURL);

            // await FlickrTask then parse results with XDocument and LINQ
            XDocument flickrXML = XDocument.Parse(await flickrTask);

            // gather information on all photos
            var flickrPhotos =
                from photo in flickrXML.Descendants("photo")
                let id = photo.Attribute("id").Value
                let title = photo.Attribute("title").Value
                let secret = photo.Attribute("secret").Value
                let server = photo.Attribute("server").Value
                let farm = photo.Attribute("farm").Value
                select new FlickrResult
                {
                    title = title,
                    flickrURL = $"https://farm{farm}.staticflickr.com/" +
                        $"{server}/{id}_{secret}.jpg"
                };
            imagesListBox.Items.Clear(); // clear imagesListBox

            // set ListBox properties only if results were found
            if (flickrPhotos.Any())
            {
                imagesListBox.DataSource = flickrPhotos.ToList();
                imagesListBox.DisplayMember = "Title";
            }
            else // no matches were found
            {
                imagesListBox.Items.Add("No matches");
            }
          }

        private async void imagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imagesListBox.SelectedItem != null)
            {
                string selectedURL =
                    ((FlickrResult)imagesListBox.SelectedItem).URL;

                // use HttpClient to get selected image's bytes asynchronously
                byte[] imageBytes =
                    await flickrClient.GetByteArrayAsync(selectedURL);

                // display downloaded image in pictureBox
                MemoryStream memoryStream = new MemoryStream(imageBytes);
                pictureBox.Image = Image.FromStream(memoryStream);
            }
        }
    }
}