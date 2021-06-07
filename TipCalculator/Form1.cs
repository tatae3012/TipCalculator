using System;
using System.Windows.Forms;

namespace TipCalculator
{
    // The Tip Calculater Form partial class with functionalities that combines with the UI displayed after run.
    // START
    public partial class Form1 : Form
    {
        // The form class constucter
        public Form1()
        {
            // The function initializes the form component.
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Loads the Tip Calculator form.
        }

        // The event definition associated with CALCULATE button.
        // START
        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                //Try fetching data from Bill textbox.
                double bill = double.Parse(textBox1.Text);

                // Bill can only be positive, so throw exception if negative value is entered.
                if (bill < 0)
                {
                    throw new Exception();
                }
                try
                {
                    // Try fetching data from Tip% textbox.
                    double tipPercent = double.Parse(numericUpDown1.Text);
                    try
                    {
                        // Try fetching data from Number of people textbox.
                        int count = int.Parse(numericUpDown2.Text);

                        // An object of type Calculator is created and 
                        // the form input values are given as parameters.
                        Calculator c = new Calculator(bill, tipPercent, count);

                        // Function calls using object c.
                        double tip = c.TipPerPerson();
                        double total = c.BillPerPerson();

                        // The calculated values are now displayed in the form as final output.
                        // The parameter emphasises that only two decimals can be displayed at max
                        textBox3.Text = ("$" + tip.ToString("0.##"));
                        textBox4.Text = ("$" + total.ToString("0.##"));
                    }      
                    catch
                    {
                        MessageBox.Show("Please Enter Number Of People");
                        numericUpDown2.Focus();
                    }
                }              
                catch
                {
                    MessageBox.Show("Please Enter Tip Amount");
                    numericUpDown1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Please Enter Positive Numerical Bill Amount");
                textBox1.Focus();
            }           
        }// END
    }// END
}
