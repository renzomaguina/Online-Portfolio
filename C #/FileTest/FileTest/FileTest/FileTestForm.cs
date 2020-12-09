﻿// Fig. 17.5 FileTestForm.cs
// Using classes File and Directory
using System;
using System.Windows.Forms;
using System.IO;

namespace FileTest
{
    // displays contents of files and directories
    public partial class FileTestForm : Form
    {
        // parameters constructor
        public FileTestForm()
        {
            InitializeComponent(); 
        } // end constructor

        // invoked when user presses key
        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // determine whether user pressed Enter key
            if ( e.KeyCode == Keys.Enter )
            {
                // get user-specified file or directory
                string fileName = inputTextBox.Text;

                // determine whether fileName is a file
                if ( File.Exists( fileName) )
                {
                    // get file's creation date, modification date, etc.
                    GetInformation(fileName);
                    StreamReader stream = null; // declare StreamReader

                    // display file contents through StreamReader
                    try
                    {
                        // obtain reader and file contents
                        using (stream = new StreamReader(fileName))
                        {
                            outputTextBox.AppendText(stream.ReadToEnd() );
                        } // end using
                    } // end try
                catch ( IOException )
                    {
                        MessageBox.Show("Error reading from file",
                            "File Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    } // end catch
                    } // end if
                    // determine whether fileName is a directory
                    else if ( Directory.Exists( fileName ))
                {
                    // get directory's creation date,
                    // modification date, etc.
                    GetInformation(fileName);

                    // obtain directory list of specified directory
                    string[] directoryList =
                        Directory.GetDirectories( fileName );

                    outputTextBox.AppendText("Directory contents:\n");

                    // output directoryList contents
                    foreach (var directory in directoryList)
                        outputTextBox.AppendText( directory + "\n");
                } // end else if
                else
                {
                    // notify user that neither file nor directory exists
                    MessageBox.Show(inputTextBox.Text +
                        " does not exist", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // end else
            } // end if
        } // end method inputTextBox_KeyDown

        // get information on file or directory,
        // and output it to outputTextBox
        private void GetInformation( string fileName )
        {
            outputTextBox.Clear();

            // output that file or directory exists
            outputTextBox.AppendText( fileName + " exists\n" );
            // output when file or directory was created
            outputTextBox.AppendText(" Created: " +
                File.GetCreationTime(fileName) + "\n" );

            // output when file or directory was last modified
            outputTextBox.AppendText(" Last modified: " +
                File.GetLastWriteTime(fileName) + "\n" );

            // output when file or directory was last accessed
            outputTextBox.AppendText(" Last accessed: " +
                File.GetLastAccessTime(fileName) + "\n" );
        } // end method GetInformation
    } // end class FileTestForm
} // end namespace FileTest
