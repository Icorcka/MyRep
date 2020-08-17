using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        int textSize;
        bool flag = true;
        const string symbols = "+-/*^";
        char dot_char = ',';
        public Form1()
        {
            
            InitializeComponent();
        }
        
        internal void ClickHolder(char a)//If a symbol or a number is added
        {
            Input.Text += a;
            
        }
        internal void ServiceClickHolder(char a)//If operation button is clicked
        {
            textSize = Input.Text.Length;
            if (textSize != 0 && Char.IsDigit(Input.Text[textSize - 1]))//Check to prevent "1++2" or "+1-4" result
            {
                Input.Text += a;                
                flag = true;
            }
        }
        
        private void Nol_Click(object sender, EventArgs e)
        {
            ClickHolder('0');
        }

        private void Two_Click(object sender, EventArgs e)
        {
            ClickHolder('2');
        }

        private void One_Click(object sender, EventArgs e)
        {
            ClickHolder('1');
        }

        private void Three_Click(object sender, EventArgs e)
        {
            ClickHolder('3');
        }

        private void Four_Click(object sender, EventArgs e)
        {
            ClickHolder('4');
        }

        private void Five_Click(object sender, EventArgs e)
        {
            ClickHolder('5');
        }

        private void Six_Click(object sender, EventArgs e)
        {
            ClickHolder('6');
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            ClickHolder('7');
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            ClickHolder('8');
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            ClickHolder('9');
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            textSize = Input.Text.Length;
            if (flag&&textSize!=0)
            {
                if (!(Char.IsDigit(Input.Text[textSize-1])))//Check to prevent "+," result
                {
                    ClickHolder('0');
                }
                ClickHolder(dot_char);
                flag = false;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Input.Text = Operations.ClearAll();
        }

        private void Pov_Click(object sender, EventArgs e)
        {
            ServiceClickHolder('^');
        }

        private void Minnus_Click(object sender, EventArgs e)
        {
            ServiceClickHolder('-');
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            ServiceClickHolder('+');
        }

        private void Div_Click(object sender, EventArgs e)
        {
            ServiceClickHolder('/');
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            ServiceClickHolder('*');
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            textSize = Input.Text.Length;
            var ep = new ErrorProvider();
            string error = String.Empty;

            //Input symbol must be numerical or be a part of "symbol" string
            if (!(Char.IsDigit(e.KeyChar)||symbols.Contains(e.KeyChar.ToString())||e.KeyChar== dot_char))
            {
                    e.Handled = true;
                    error = String.Format("Неверное значение");
            }
            if(Char.IsDigit(e.KeyChar))
            {
                textSize++;
            }
            if (symbols.Contains(e.KeyChar.ToString()))//if char-operation has been typed
            {
                if (textSize != 0 && Char.IsDigit(Input.Text[textSize - 1]))
                {
                    textSize++;                    
                    flag = true;
                }
                else
                {
                    e.Handled = true;
                    error = String.Format("Неверное значение");
                }
            }
            if (e.KeyChar == dot_char)//If dot has been pressed
            {
                if (flag && textSize != 0)
                {
                    {
                        if (!(Char.IsDigit(Input.Text[textSize - 1])))
                        {
                            e.Handled = true;
                            error = String.Format("Неверное значение");
                        }
                        else
                        {
                            textSize++;
                            flag = false;
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                    error = String.Format("Неверное значение");
                }
            }
            ep.SetError(Input, error);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Char.IsDigit(Input.Text[Input.Text.Length-1]))
            {
                Operations output = new Operations(Input.Text);//Transfering string value to class "Operations"
                Output.Text = output.getResult();
            }
            else
            {
                Output.Text = "Error";
            }
        }

        private void ChangeSys_Click(object sender, EventArgs e)//If number 1,9 is not recognized by computer as double
        {
            if (dot_char == '.')
                dot_char = ',';
            else
                dot_char = '.';
        }
    }
}
