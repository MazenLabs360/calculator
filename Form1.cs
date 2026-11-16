using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string number1,number2 = "";
        string Operation = "++";
        bool NewOperation = true;
        int FirstNumber = 0;
        int SecondNumber = 0;
       
        public Form1()
        {
            InitializeComponent();
        }
        private void NumberClicked(object sender, EventArgs e)
        {
           
            if (NewOperation)
            {
                if (Operation != "++")
                {
                    
                    number2 += ((Button)sender).Text;
                    label3.Text = number2;
                }
                else 
                {
                    number1 += ((Button)sender).Text;
                    label1.Text = number1;
                }

                
            }
        
        }

        /*private void NumberClicked2(object sender, EventArgs e)
        {
            if (Operation != null)
            {
                label3.Text += ((Button)sender).Text;
            }
        }*/

        private void ArihmeticOperationClick(object sender, EventArgs e)
        {
         if (NewOperation)
            {
                Operation = ((Button)sender).Text;
                label2.Text = Operation;

            }

        
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
           

           // if (FirstNumber == 0 || Operation != null || SecondNumber == 0)
                //return ;
                //MessageBox.Show("ii");

            FirstNumber = Convert.ToInt32(label1.Text);
            SecondNumber = Convert.ToInt32(label3.Text);
            label5.Text = "";
            if (Operation == "+")
            {
                label5.Text = (FirstNumber + SecondNumber).ToString();

            }
            else if (Operation == "-")
            {
                label5.Text = (FirstNumber - SecondNumber).ToString();
            }
            else if (Operation == "*")
            {
                label5.Text = (FirstNumber * SecondNumber).ToString();
            }
            else if (Operation == "/")
            {
                if (SecondNumber == 0 || FirstNumber == 0)
                {
                    MessageBox.Show("لا يمكن القسمة على صفر");
                    return;
                }

                label5.Text = ((double)FirstNumber / SecondNumber).ToString();
            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            label1.Text = label5.Text;
            label3.Text = "0";
            label5.Text = "0";
            FirstNumber = 0;
            SecondNumber = 0;
            number1 = "0";
            number2 = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label3.Text = "0";
            label5.Text = "0";
            FirstNumber = 0;
            SecondNumber = 0;
            number1 = "0";
            number2 = "0";
            label2.Text = "++";
            Operation = "++";
        }

        private void OFFClick(object sender, EventArgs e)
        {
            NewOperation = true;
        }

        private void ONClick(object sender, EventArgs e)
        {
            NewOperation = false;
        }
    }
}
