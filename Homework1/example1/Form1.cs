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
        private MyClass mc = new MyClass();

        public Form1()
        {
            InitializeComponent();
        }

        public void btmequals_Click(object sender, EventArgs e)
        {
            double x = double.Parse(texA.Text);
            double y = double.Parse(texB.Text);
            int texSelectNum = mc.texSelectNum;
            if (texSelectNum == 1)                   //+
                texResult.Text = (x + y).ToString();
            else if (texSelectNum == 2)              //-
                texResult.Text = (x - y).ToString();
            else if (texSelectNum == 3)              //*
                texResult.Text = (x * y).ToString();
            else if (texSelectNum == 4)              // /
                texResult.Text = (x / y).ToString();
            else { }
        }

        public void btmplus_Click(object sender, EventArgs e)
        {
            if (texResult.Text != "")
            { }
            else
            {
                mc.texSelectNum = 1;
                texSelectNum.Text = "+";
            }
        }

        public void btmminus_Click(object sender, EventArgs e)
        {
            if (texResult.Text != "")
            { }
            else
            {
                mc.texSelectNum = 2;
                texSelectNum.Text = "-";
            }
        }

        private void btmtimes_Click(object sender, EventArgs e)
        {
            if (texResult.Text != "")
            { }
            else
            {
                mc.texSelectNum = 3;
                texSelectNum.Text = "*";
            }
        }

        private void btmdivide_Click(object sender, EventArgs e)
        {
            if (texResult.Text != "")
            { }
            else
            {
                mc.texSelectNum = 4;
                texSelectNum.Text = "/";
            }
        }

        public void texA_TextChanged(object sender, EventArgs e)
        {
        }

        public void btm0_Click(object sender, EventArgs e)
        {
            mc.keyinString = "0";
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = mc.keyinString;
            }
            else
            {
                texB.Text = mc.keyinString;
            }
        }

        private void btm1_Click(object sender, EventArgs e)
        {
            mc.keyinString = "1";
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = mc.keyinString;
            }
            else
            {
                texB.Text = mc.keyinString;
            }
        }

        private void btm2_Click(object sender, EventArgs e)
        {
            mc.keyinString = "2";
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = mc.keyinString;
            }
            else
            {
                texB.Text = mc.keyinString;
            }
        }

        private void btm3_Click(object sender, EventArgs e)
        {
            mc.keyinString = "3";
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = mc.keyinString;
            }
            else
            {
                texB.Text = mc.keyinString;
            }
        }

        private void btm4_Click(object sender, EventArgs e)
        {
            mc.keyinString = "4";
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = mc.keyinString;
            }
            else
            {
                texB.Text = mc.keyinString;
            }
        }

        public void btm5_Click(object sender, EventArgs e)
        {
            mc.keyinString = "5";
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = mc.keyinString;
            }
            else
            {
                texB.Text = mc.keyinString;
            }
        }

        private void btm6_Click(object sender, EventArgs e)
        {
            mc.keyinString = "6";
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = mc.keyinString;
            }
            else
            {
                texB.Text = mc.keyinString;
            }
        }

        private void btm7_Click(object sender, EventArgs e)
        {
            mc.keyinString = "7";
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = mc.keyinString;
            }
            else
            {
                texB.Text = mc.keyinString;
            }
        }

        private void btm8_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                mc.keyinString = "8";
                texA.Text = mc.keyinString;
            }
            else
            {
                texB.Text = mc.keyinString;
            }
        }

        private void btm9_Click(object sender, EventArgs e)
        {
            mc.keyinString = "9";
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                texA.Text = mc.keyinString;
            }
            else
            {
                texB.Text = mc.keyinString;
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