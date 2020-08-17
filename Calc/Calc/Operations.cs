using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    class Operations
    {
        delegate double Action(double a, double b);
        private List<double> numbers= new List<double> { };
        private List<Action> operators= new List<Action> { };
        bool controller= true;
        public Operations(string text)//Converting a string into two lists(list of numbers and operations)
        {
            if(text.Length==0)
            {
                controller = false;
            }
            string num= "";
            Action template;
            var operator_line = "+-/*^";
            for(int i= 0; i<text.Length;i++)
            {
                if (!operator_line.Contains(text[i].ToString()))
                {
                    num += text[i].ToString();
                }
                else
                {
                    numbers.Add(Convert.ToDouble(num));
                    num = ClearAll();
                    switch(text[i])
                    {
                        case '+':
                            template = (a, b) => a + b;
                            operators.Add(template);
                            break;
                        case '-':
                            template = (a, b) => a - b;
                            operators.Add(template);
                            break;
                        case '/':
                            template = (a, b) => a / b;
                            operators.Add(template);
                            break;
                        case '*':
                            template = (a, b) => a * b;
                            operators.Add(template);
                            break;
                        case '^':
                            template = (a, b) => Math.Pow(a, b);
                            operators.Add(template);
                            break;
                    }
                }
            }
            numbers.Add(Convert.ToDouble(num));
        }
        public string getResult()
        {
            for(int i= 1; i<numbers.Count;i++)
            {
                if(ZeroDivCheck(operators[i-1], numbers[i]))
                {
                    return "Деление на 0";
                }
            }
            if (controller&&operators.Count>0)
            {
                for (int i = 0; i < numbers.Count - 1; i++)//Executing "^"operations
                {
                    if (checkPowDelegate(operators[i]))
                    {
                        numbers[i] = operators[i](numbers[i], numbers[i + 1]);
                        numbers.RemoveAt(i + 1);
                        operators.RemoveAt(i);
                    }
                }
                int j= 0;
                while (j<numbers.Count-1)//Executing prior operations
                {
                    for(int i= 0; i<numbers.Count-1;i++)
                    {
                        if(checkDelegate(operators[i]))
                        {
                            numbers[i] = operators[i](numbers[i], numbers[i + 1]);  
                            numbers.RemoveAt(i+1);
                            operators.RemoveAt(i);
                            j = 0;
                            break;
                        }
                        j++;
                    }
                }
                double result = numbers[0];
                for (int i = 1; i < numbers.Count; i++)//Executing rest of operations
                {
                    result = operators[i-1](result, numbers[i]);
                }
                return result.ToString();
            }
            else if(numbers.Count==1)
            {
                return numbers[0].ToString();
            }
            else
            {
                return "Error";
            }
        }
        public static string ClearAll()
        {
            return "";
        }
        private bool checkDelegate(Action a)
        {
            if(a(2, 1)==2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkPowDelegate(Action a)
        {
            if (a(3, 2) == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ZeroDivCheck(Action a, double d)
        {
            if(a(2,2)==1&&d==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
