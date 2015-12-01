using exampleLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btmequals_Click(object sender, EventArgs e)
        {
            double x = double.Parse(texA.Text);
            double y = double.Parse(texB.Text);
            // double result = 0.0;
            if (texSelectNum.Text == "+") //+
                texResult.Text = (x + y).ToString();
            else if (texSelectNum.Text == "-") //-
                texResult.Text = (x - y).ToString();
            else if (texSelectNum.Text == "*") //*
                texResult.Text = (x * y).ToString();
            else if (texSelectNum.Text == "/") // /
                texResult.Text = (x / y).ToString();
            else { }
        }

        public void btmplus_Click(object sender, EventArgs e)
        {
            if (texResult.Text != "")
            { }
            else
            {
                texSelectNum.Text = "+";
            }
        }

        public void btmminus_Click(object sender, EventArgs e)
        {
            if (texResult.Text != "")
            { }
            else
            {
                texSelectNum.Text = "-";
            }
        }

        private void btmtimes_Click(object sender, EventArgs e)
        {
            if (texResult.Text != "")
            { }
            else
            {
                texSelectNum.Text = "*";
            }
        }

        private void btmdivide_Click(object sender, EventArgs e)
        {
            if (texResult.Text != "")
            { }
            else
            {
                texSelectNum.Text = "/";
            }
        }

        public void texA_TextChanged(object sender, EventArgs e)
        {
        }

        public void btm0_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = 0.ToString();
            }
            else
            {
                texB.Text = 0.ToString();
            }
        }

        private void btm1_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = 1.ToString();
            }
            else
            {
                texB.Text = 1.ToString();
            }
        }

        private void btm2_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = 2.ToString();
            }
            else
            {
                texB.Text = 2.ToString();
            }
        }

        private void btm3_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = 3.ToString();
            }
            else
            {
                texB.Text = 3.ToString();
            }
        }

        private void btm4_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = 4.ToString();
            }
            else
            {
                texB.Text = 4.ToString();
            }
        }

        public void btm5_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = 5.ToString();
            }
            else
            {
                texB.Text = 5.ToString();
            }
        }

        private void btm6_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = 6.ToString();
            }
            else
            {
                texB.Text = 6.ToString();
            }
        }

        private void btm7_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = 7.ToString();
            }
            else
            {
                texB.Text = 7.ToString();
            }
        }

        private void btm8_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = 8.ToString();
            }
            else
            {
                texB.Text = 8.ToString();
            }
        }

        private void btm9_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = 9.ToString();
            }
            else
            {
                texB.Text = 9.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btmac_Click(object sender, EventArgs e)
        {
            texA.Text = "";
            texB.Text = "";
            texSelectNum.Text = "";
            texResult.Text = "";
        }
    }
}