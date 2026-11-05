using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
           const double HIGH_SCORE = 95.0; // Constant for the highest score
           const double Passing_SCORE = 60.0; // Constant for the lowest score
           double test1, test2, test3; // To hold the test scores

            try
                {
                // Get the test scores from the TextBoxes.
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);
                // Calculate the average of the test scores.
                double average = (test1 + test2 + test3) / 3;
                // Display the average in the averageLabel control.
                averageLabel.Text = average.ToString("n1");
                // Check if the average is a high score or a passing score.
                if (average >= HIGH_SCORE)
                {
                    MessageBox.Show("A");
                }
                else if (average >=80 && average < HIGH_SCORE)
                {
                    MessageBox.Show("B");
                }
                if (average >= 70 && average < 80)
                {
                    MessageBox.Show("C");
                if (average >= 60 && average < 70)
                    {
                        MessageBox.Show("D");
                    } 
                    if (average >= 60)
                    {
                        MessageBox.Show("F");
                    }
                    
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for all test scores.");
            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the averageLabel control.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // Reset the focus to test1.
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void test2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void test3TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void averageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
