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
            //double x = double.Parse(texA.Text);
            //double y = double.Parse(texB.Text);
            int texSelectNum = mc.texSelectNum;
            if (texSelectNum == 1)                   //+
                texResult.Text = (mc.keyinAnum + mc.keyinBnum).ToString();
            else if (texSelectNum == 2)              //-
                texResult.Text = (mc.keyinAnum - mc.keyinBnum).ToString();
            else if (texSelectNum == 3)              //*
                texResult.Text = (mc.keyinAnum * mc.keyinBnum).ToString();
            else if (texSelectNum == 4)              // /
                texResult.Text = (mc.keyinAnum / mc.keyinBnum).ToString();
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
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                mc.keyinAnum = 0;
            }
            else
            {
                mc.keyinAnum = 0;
            }
        }

        private void btm1_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                mc.keyinAnum = 1;
            }
            else
            {
                mc.keyinBnum = 1;
            }
        }

        private void btm2_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                mc.keyinAnum = 2;
            }
            else
            {
                mc.keyinBnum = 2;
            }
        }

        private void btm3_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                mc.keyinAnum = 3;
            }
            else
            {
                mc.keyinBnum = 3;
            }
        }

        private void btm4_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                mc.keyinAnum = 4;
            }
            else
            {
                mc.keyinBnum = 4;
            }
        }

        public void btm5_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                mc.keyinAnum = 5;
            }
            else
            {
                mc.keyinBnum = 5;
            }
        }

        private void btm6_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                mc.keyinAnum = 6;
            }
            else
            {
                mc.keyinBnum = 6;
            }
        }

        private void btm7_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                mc.keyinAnum = 7;
            }
            else
            {
                mc.keyinBnum = 7;
            }
        }

        private void btm8_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                mc.keyinAnum = 8;
            }
            else
            {
                mc.keyinBnum = 8;
            }
        }

        private void btm9_Click(object sender, EventArgs e)
        {
            if (((texA.Text == "0") || (texA.Text == "")) && ((texB.Text == "0") || (texB.Text == "")))
            {
                mc.keyinAnum = 9;
            }
            else
            {
                mc.keyinBnum = 9;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            texA.Text = mc.keyinAnum.ToString();
            texB.Text = mc.keyinBnum.ToString();
        }

        private void btmac_Click(object sender, EventArgs e)
        {
            texA.Text = "";
            texB.Text = "";
            texSelectNum.Text = "";
            texResult.Text = "";
            mc.keyinAnum = 0;
            mc.keyinBnum = 0;
            mc.texSelectNum = 0;
        }
    }
}