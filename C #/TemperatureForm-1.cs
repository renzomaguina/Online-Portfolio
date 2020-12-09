using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4graded1
{
    public partial class TemperatureForm : Form
    {
        //contructor
        public TemperatureForm()
        {
            InitializeComponent();
        }
        //end constructor
        //event handler that converts temperature

        private void convertButton_Click(object sender, EventArgs e)
        {
            int fahrenheit;
            int celsius;
            fahrenheit = Convert.ToInt32(fahrenheitTextBox .Text);
            celsius = Convert.ToInt32(5.0 / 9.0 * (fahrenheit - 32)
            );
            displayLabel.Text = fahrenheit +
            " degrees Fahrenheit is\n" + celsius + " degrees Celsius";
        }//end method convertButton_Click
    }//End class TemperatureForm
}//end namespace Temperature
