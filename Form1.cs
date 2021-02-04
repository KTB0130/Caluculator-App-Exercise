using System;
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
        Class1 head;
        Class1 current;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            head = null;
            current = head;
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
            AddToList("+");
            PrintList();
            txtInput.Text = txtInput.Text + "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            AddToList("-");
            PrintList();
            txtInput.Text = txtInput.Text + "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            AddToList("*");
            PrintList();
            txtInput.Text = txtInput.Text + "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            AddToList("/");
            PrintList();
            txtInput.Text = txtInput.Text + "/";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            AddToList("=");
            PrintList();
            txtInput.Clear();
            double answer = Caluculate();
            txtInput.Text = "" + answer;
            lblOutput.Text = lblOutput.Text + "=" + answer;
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
            head = null;
            current = null;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 0;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + ".";
        }

        private void AddToList(string s)
        {
            if (Double.TryParse(txtInput.Text, out first))
            {
                if(head == null)
                { 
                    head = new Class1();
                    current = head;
                    current.number = first;
                    current.n = true;

                    current.next = new Class1();
                    current = current.next;
                    current.symbol = s;
                    current.n = false;
                    current.next = null;
                }
                else
                {
                    current.next = new Class1();
                    current = current.next;
                    current.number = first;
                    current.n = true;

                    current.next = new Class1();
                    current = current.next;
                    current.symbol = s;
                    current.n = false;
                    current.next = null;
                }
            }
            else
            {
                lblOutput.Text = "Error";
                txtInput.Clear();
            }

        }

        private void PrintList()
        {
            Class1 print = head;
            string temp = "";
            while (print != null)
            {
                if (print.n)
                {
                    temp = temp + print.number;
                }
                else
                {
                    temp = temp + print.symbol;
                }
                print = print.next;
            }
            lblOutput.Text = temp;
        }

        private double Caluculate()
        {
            double a = 0;
            Multiply();
            Division();
            Addition();
            Subtraction();
            return a;
        }
        private void Multiply()
        {
            Class1 m = head;
            Class1 temp;

            while(m.symbol != "=")
            {
                if (m.next.symbol == "*")//exeption thrown 
                {
                    double answer = m.number * m.next.next.number;//error
                    temp = m.next.next.next;
                    m.next = temp;
                    answer = m.number;
                }
                m = m.next;
            }


        }
        private void Division()
        {
            Class1 m = head;
            Class1 temp;

            while (m.symbol != "=")
            {
                if (m.next.symbol == "/")
                {
                    double answer = m.number * m.next.next.number;
                    temp = m.next.next.next;
                    m.next = temp;
                    answer = m.number;
                }


                m = m.next;
            }


        }
        private void Addition()
        {
            Class1 m = head;
            Class1 temp;

            while (m.symbol != "=")
            {
                if (m.next.symbol == "+")
                {
                    double answer = m.number * m.next.next.number;//error here when ran
                    temp = m.next.next.next;
                    m.next = temp;
                    answer = m.number;
                }


                m = m.next;
            }


        }
        private void Subtraction()
        {
            Class1 m = head;
            Class1 temp;

            while (m.symbol != "=")
            {
                if (m.next.symbol == "-")
                {
                    double answer = m.number * m.next.next.number;
                    temp = m.next.next.next;
                    m.next = temp;
                    answer = m.number;
                }


                m = m.next;
            }
        }    

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char p = e.KeyChar;
            if (p == '1' || p == '2' || p == '3' || p == '4' || p == '5' || p == '6' || p == '7' || p == '8' || p == '9' || p == 'e')
            {
                Console.WriteLine("Number Pressed:" + p);
                if(txtInput.Text == "Error")
                {
                    txtInput.Clear();
                }
                txtInput.Text = txtInput.Text + p;
            }
            else if (p == '+' || p == '-' || p == '*' || p == '/')
            {
                Console.WriteLine("Symbol Pressed:" + p);
                string s = "" + p;
                AddToList(s);
                PrintList();
                txtInput.Clear();
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                Console.WriteLine("Enter Pressed:" + p);
                AddToList("=");
                PrintList();
                txtInput.Clear();
                double answer = Caluculate();
                txtInput.Text = "" + answer;
            }

        }
            

        

    }

}

