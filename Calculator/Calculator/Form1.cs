using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        String results = "";
        double calculator = 0.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press 1");
            results = results + "1";
            MessageBox.Show(results);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press 2");
            results = results + "2";
            MessageBox.Show(results);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press 3");
            results = results + "3";
            MessageBox.Show(results);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press 4");
            results = results + "4";
            MessageBox.Show(results);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press 5");
            results = results + "5";
            MessageBox.Show(results);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press 6");
            results = results + "6";
            MessageBox.Show(results);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press 7");
            results = results + "7";
            MessageBox.Show(results);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press 8");
            results = results + "8";
            MessageBox.Show(results);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press 9");
            results = results + "9";
            MessageBox.Show(results);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press add");
            results = results + "+";
            MessageBox.Show(results);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press multiply");
            results = results + "*";
            MessageBox.Show(results);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press 0");
            results = results + "0";
            MessageBox.Show(results);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press divide");
            results = results + "/";
            MessageBox.Show(results);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press subtract");
            results = results + "-";
            MessageBox.Show(results);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I press Enter");
            results = results + "";
            MessageBox.Show(results);
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
    }
}
