﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caluculator_App_Exercise
{
    public partial class Calculator : Form
    {
        double first, second, answer;
        string function;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 5;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 4;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 9;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(Double.TryParse(txtInput.Text, out first))
            {
                function = " + ";
                lblOutput.Text = txtInput.Text + function;
                txtInput.Clear();
            }
            else
            {
                txtInput.Text = "Error";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtInput.Text, out first))
            {
                function = " - ";
                lblOutput.Text = txtInput.Text + function;
                txtInput.Clear();
            }
            else
            {
                txtInput.Text = "Error";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtInput.Text, out first))
            {
                function = " * ";
                lblOutput.Text = txtInput.Text + function;
                txtInput.Clear();
            }
            else
            {
                txtInput.Text = "Error";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtInput.Text, out first))
            {
                function = " / ";
                lblOutput.Text = txtInput.Text + function;
                txtInput.Clear();
            }
            else
            {
                txtInput.Text = "Error";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            
            if (Double.TryParse(txtInput.Text, out second))
            {
                if (function == " + ")
                {
                    answer = first + second;
                }
                else if (function == " - ")
                {
                    answer = first - second;
                }
                else if (function == " * ")
                {
                    answer = first * second;
                }
                else if (function == " / ")
                {
                    answer = first / second;
                }
            }
            else
            {
                txtInput.Text = "Error";
            }
            lblOutput.Text = lblOutput.Text + second + " = " + answer;
            txtInput.Clear();
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            first = second = answer = 0;
            lblOutput.Text = "";
            function = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 0;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + ".";
        }

    }
}
