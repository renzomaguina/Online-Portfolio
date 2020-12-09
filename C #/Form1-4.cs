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


namespace ReadSequentialAccessFile
{
    public class Record
    {
        // auto-implemented Account property 
        public int Account { get; set; } 

        // auto-implemented FirstName property 
         public string FirstName { get; set; } 

        // auto-implemented LastName property
        public string LastName{get; set;}

        // auto-implemented Balance property 
        public decimal Balance { get; set; } 
        
        // parameterless constructor sets members to default values 
        public Record() 
            : this( 0, string.Empty, string.Empty, 0M ) 
        { 
        } // end constructor 
        
        // overloaded constructor sets members to parameter values 
        public Record( int accountValue, string firstNameValue, 
            string lastNameValue, decimal balanceValue ) 
        { 	Account = accountValue; 
            FirstName = firstNameValue; 
            LastName = lastNameValue; 
            Balance = balanceValue; 
        } // end constructor 
    } // end class Record 
 // end namespace BankLibrary

    public partial class ReadSequentialAccessFileForm : Form
    {
        private StreamReader fileReader; // reads data from a text file
        public ReadSequentialAccessFileForm()
        {
            InitializeComponent();
        }

     
        public void ClearTextBoxes() 
        { 
            // iterate through every Control on form 
            foreach ( Control guiControl in Controls ) 
            { 
                // determine whether Control is TextBox 
                if ( guiControl is TextBox ) 
                { 
                    // clear TextBox 
                    ( ( TextBox ) guiControl ).Clear(); 
                } // end if 	
            } // end for 
        }// end method ClearTextBoxes 

        private void openButton_Click(object sender, EventArgs e)
        {
            // create and show dialog box enabling user to open file 
            DialogResult result; // result of OpenFileDialog 
            string fileName; // name of file containing data 
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // get specified name 
            } // end using 
            // ensure that user clicked "OK" 
            if (result == DialogResult.OK)
            {
                ClearTextBoxes();

                // show error if user specified invalid file 
                if (fileName == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        // create FileStream to obtain read access to file 
                        FileStream input = new FileStream(
                            fileName, FileMode.Open, FileAccess.Read);
                        // set file from where data is read 
                        fileReader = new StreamReader(input);
                        openButton.Enabled = false; // disable Open File button 
                        nextButton.Enabled = true; // enable Next Record button

                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error reading from file",
                           "File Error", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    } //end catch 
                }//end else
            }//end if
        }// end method openButton_Click

            // invoked when user clicks Next button 
            private void nextButton_Click( object sender, EventArgs e )
                { 
                try 
                { 
                    // get next record available in file 
                    string inputRecord = fileReader.ReadLine();
                    string[] inputFields; // will store individual pieces of data 
                    if ( inputRecord != null ) 
                    { 
                        inputFields = inputRecord.Split( ',' );

                        Record record = new Record( 	
                            Convert.ToInt32( inputFields[ 0 ] ), inputFields[ 1 ], 
                            inputFields[ 2 ], 
                            Convert.ToDecimal( inputFields[ 3 ] ) ); 



                        // copy string-array values to TextBox values 
                        //SetTextBoxValues( inputFields ); 
                    } // end if 
                    else 
                    { 
                        // close StreamReader and underlying file 
                        openButton.Enabled = true; // enable Open File button 
                        nextButton.Enabled = false; // disable Next Record button 
                        ClearTextBoxes(); 
                        // notify user if no records in file 
                        MessageBox.Show( "No more records in file", string.Empty, 
                            MessageBoxButtons.OK, MessageBoxIcon.Information ); 
                    } // end else 
                }// end try 
                catch ( IOException ) 
                { 
                    MessageBox.Show( "Error Reading from File", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error ); 
                } // end catch 	
            }// end method nextButton_Click 
    } // end class ReadSequentialAccessFileForm 
} // end namespace ReadSequentialAccessFile
       
