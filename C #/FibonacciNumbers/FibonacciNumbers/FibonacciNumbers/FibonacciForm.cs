// Unit 4 Guided Practice 1
// Asynchronous access using threads
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciTest
{
    public partial class FibonacciForm : Form
    {
        private long n1 = 0; // intialize with first fibonacci number
        private long n2 = 1; // intialize with second fibonacci number
        private int count; // current fibonacci number to display
        public FibonacciForm()
        {
            InitializeComponent();
        }

        private async void calculateButton_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = DateTime.Now;

            // retrieve user's input as an integer
            int number = int.Parse(inputTextBox.Text);
  

            try {

                int.Parse(inputTextBox.Text);
            }


            catch (FormatException)
            {
                MessageBox.Show("PLEASE ENTER A NUMBER!", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            asyncResultLabel.Text = "Calculating...";

            // Task to perform Fibonacci calculation in separate thread
            Task<long> fibonacciTask = Task.Run(() => Fibonacci(number));

            // wait for task in separate thread to complete
            await fibonacciTask;

            // display result after Task in separate thread completes
            asyncResultLabel.Text = fibonacciTask.Result.ToString();

           double  minutes = (endTime - startTime).TotalMinutes;
            timerLabel.Text = $"Calculation Time : {minutes:F6} minutes";
        }
            

        private void nextNumberButton_Click(object sender, EventArgs e)
        {
            // calculate the next Fibonacci number
            long temp = n1 + n2; // calculate next fibonacci number
            n1 = n2; // store prior fibonaci number in int
            n2 = temp; // store new fibonacci
            ++count;

            // display the next fibonacci number
            displayLabel.Text = $"Fibonacci of {count}:";
            syncResultLabel.Text = n2.ToString();
        }

        // recursive method Fibonacci; calculates nth Fibonacci number
        public long Fibonacci(long n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
