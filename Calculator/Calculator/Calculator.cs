using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        String results = "";
        String firstPart = "";
        String secondPart = "";
        String currentOperation = "";
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            results = results + "1";
            textBox1.Text = results;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            results = results + "2";
            textBox1.Text = results;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            results = results + "3";
            textBox1.Text = results;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            results = results + "4";
            textBox1.Text = results;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            results = results + "5";
            textBox1.Text = results;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            results = results + "6";
            textBox1.Text = results;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            results = results + "7";
            textBox1.Text = results;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            results = results + "8";
            textBox1.Text = results;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            results = results + "9";
            textBox1.Text = results;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            firstPart = textBox1.Text;
            textBox1.Text = "";
            currentOperation = "+";
            results = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            firstPart = textBox1.Text;
            textBox1.Text = "";
            currentOperation = "-";
            results = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            secondPart = textBox1.Text;
            textBox1.Text = "";
            results = "";
            if (currentOperation == "/")
            {
                try
                {
                    textBox1.Text = (int.Parse(firstPart) / int.Parse(secondPart)).ToString();
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(@"Idiot! " + ex.Message); 
                }
                
                
            }

            if (currentOperation == "*")
            {
                textBox1.Text = (int.Parse(firstPart) * int.Parse(secondPart)).ToString();
            }

            if (currentOperation == "+")
            {
                textBox1.Text = (int.Parse(firstPart) + int.Parse(secondPart)).ToString();
                
            }
            if (currentOperation == "-")
            {
                textBox1.Text = (int.Parse(firstPart) - int.Parse(secondPart)).ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            results = results + "0";
            textBox1.Text = results;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstPart = textBox1.Text;
            textBox1.Text = "";
            currentOperation = "*";
            results = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstPart = textBox1.Text;
            textBox1.Text = "";
            currentOperation = "/";
            results = "";
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            results = "";
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                results = results.Remove(results.Length - 1, 1);
                textBox1.Text = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            firstPart = textBox1.Text;
            
            try
            {
                textBox1.Text = (int.Parse(firstPart) * int.Parse(firstPart)).ToString();
                results = "";
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
