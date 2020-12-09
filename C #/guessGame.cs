using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4graded2
{
    public partial class guessGame : Form
    {
        public guessGame()
        {

            InitializeComponent();
        }

        Random number = new Random(); // This is declaring number; our randomizer
        int randomNumber; // Our randomized number
        int guessNumber; // Our guessed number



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            guessNumber = Convert.ToInt32(textBox.Text);

            if (guessNumber > randomNumber)
            {
                displayLabel.Text = ("Guess was too high, try again!");
            }

            else if (guessNumber < randomNumber)
            {
                displayLabel.Text = ("Guess was too low, try again!");

            }

            if (guessNumber == randomNumber)
            {
                displayLabel.Text = ("Awesome, guess was right!");
            }
        }

        private void guessGame_Load(object sender, EventArgs e)
        {
            
        }
    
    }
    
  }

