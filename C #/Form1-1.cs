using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Test
{
    public partial class FileTestForm : Form
    {
        //parameterless constructor
        public FileTestForm()
        {
            InitializeComponent();
        }//end constructor

        // invoked when user presses key 
        private void inputTextBox_KeyDown( object sender, KeyEventArgs e ) 
        { 	
            // determine whether user pressed Enter key 
            if ( e.KeyCode == Keys.Enter ) 
            { 
                // get user-specified file or directory 
                string fileName = inputTextBox.Text; 
                // determine whether fileName is a file 
                if ( File.Exists( fileName ) ) 
                { 
                    // get file's creation date, modification date, etc. 
                    GetInformation( fileName ); 
                    StreamReader stream = null; // declare StreamReader

                    try 
                    { 
                        // obtain reader and file contents 
                        using ( stream = new StreamReader( fileName ) ) 
                        { 
                            outputTextBox.AppendText( stream.ReadToEnd() ); 
                        } // end using 
                    }
                    // end try 
                    catch ( InvalidOperationException ) 
                    { 
                        MessageBox.Show( "Error reading from file", 
                            "File Error", MessageBoxButtons.OK, 
                            MessageBoxIcon.Error ); 
                    } // end catch 
                }// end if 
                // determine whether fileName is a directory 
                else if ( Directory.Exists( fileName ) ) 
                { 
                    // get directory's creation date, 
                    // modification date, etc. 
                    GetInformation( fileName ); 
                    // obtain directory list of specified directory 
                    string[] directoryList = Directory.GetDirectories(fileName);

                    outputTextBox.AppendText( "Directory contents:\n" ); 

                    // output directoryList contents 
                    foreach ( var directory in directoryList ) 
                        outputTextBox.AppendText( directory + "\n" ); 
                } // end else if 
                else 
                { 
                    // notify user that neither file nor directory exists 
                    MessageBox.Show( inputTextBox.Text + " does not exist", "File Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error ); 
                } // end else 	
            }// end if 
        } // end method inputTextBox_KeyDown 
        // get information on file or directory, 
        // and output it to outputTextBox 
        private void GetInformation(string fileName)
        {
            outputTextBox.Clear();
            // output that file or directory exists 
            outputTextBox.AppendText(fileName + " exists\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inputTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            // determine whether user pressed Enter key 
            if (e.KeyCode == Keys.Enter)
            {
                // get user-specified file or directory 
                string fileName = inputTextBox.Text;
                // determine whether fileName is a file 
                if (File.Exists(fileName))
                {
                    // get file's creation date, modification date, etc. 
                    GetInformation(fileName);
                    StreamReader stream = null; // declare StreamReader

                    try
                    {
                        // obtain reader and file contents 
                        using (stream = new StreamReader(fileName))
                        {
                            outputTextBox.AppendText(stream.ReadToEnd());
                        } // end using 
                    }
                    // end try 
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("Error reading from file",
                            "File Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    } // end catch 
                }// end if 
                // determine whether fileName is a directory 
                else if (Directory.Exists(fileName))
                {
                    // get directory's creation date, 
                    // modification date, etc. 
                    GetInformation(fileName);
                    // obtain directory list of specified directory 
                    string[] directoryList = Directory.GetDirectories(fileName);

                    outputTextBox.AppendText("Directory contents:\n");

                    // output directoryList contents 
                    foreach (var directory in directoryList)
                        outputTextBox.AppendText(directory + "\n");
                } // end else if 
                else
                {
                    // notify user that neither file nor directory exists 
                    MessageBox.Show(inputTextBox.Text + " does not exist", "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // end else 	
            }// end if 
        }

        
    }
}
