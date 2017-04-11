using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Web_Controls_and_HTML_Controls
{
    public partial class Calculator : System.Web.UI.Page
    {
        private readonly ILogic calc;
        public Calculator()
        {
            this.calc = new Logic();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            //this.Label1.Text = "Result: ";
            //this.TextBox1.Text = "";
            this.calc.ClearCalculations(this.Label1, this.TextBox1);
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            //this.TextBox1.Text += button.Text;
            this.calc.SavingEquation(button, this.TextBox1);
        }

        protected void Equal_Click(object sender, EventArgs e)
        {
            var equation = this.TextBox1.Text;

            var result = this.calc.Calculations(equation);

            this.Label1.Text += result.ToString();

            //double result = 0;

            //if (equation.Contains("+"))
            //{
            //    var numbers = equation.Split('+');
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        result += int.Parse(numbers[i]);
            //    }
            //}
            //else if (equation.Contains("-"))
            //{
            //    var numbers = equation.Split('-');

            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        result -= int.Parse(numbers[i]);
            //    }
            //}
            //else if (equation.Contains("*"))
            //{
            //    var numbers = equation.Split('*');
            //    result += int.Parse(numbers[0]);

            //    for (int i = 1; i < numbers.Length; i++)
            //    {
            //        result *= int.Parse(numbers[i]);
            //    }
            //}
            //else if (equation.Contains("/"))
            //{
            //    var numbers = equation.Split('/');
            //    result += int.Parse(numbers[0]);

            //    for (int i = 1; i < numbers.Length; i++)
            //    {
            //        result /= int.Parse(numbers[i]);
            //    }
            //}
            //else if (equation.Contains("root"))
            //{
            //    var numbers = equation.Split(new char[] { 'r', 'o', 'o', 't' });

            //    var firstNumber = int.Parse(numbers[4]);

            //    result = Math.Sqrt(firstNumber);
            //}



            //var finalResult = 0;
            //var firstNumber = 0;
            //foreach (var element in equation)
            //{
            //    if (char.IsDigit(element))
            //    {
            //        firstNumber = int.Parse(element.ToString());
            //    }
            //    else
            //    {
            //        switch (element)
            //        {
            //            case '+':
            //                finalResult += firstNumber;
            //                break;
            //            case '-':
            //                finalResult -= firstNumber;
            //                break;
            //            case '*':
            //                if (finalResult != 0)
            //                {
            //                    finalResult *= firstNumber;
            //                }
            //                else
            //                {
            //                    finalResult += 1;
            //                    finalResult *= firstNumber;
            //                }
            //                break;
            //            case '/':
            //                if (finalResult!=0)
            //                {
            //                    finalResult /= firstNumber;
            //                }
            //                else
            //                {
            //                    continue;
            //                }
            //                break;
            //            case 'R':
            //                //finalResult += Math.Sqrt(firstNumber);
            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //}

            //this.Label1.Text += finalResult.ToString();
        }
    }

    public class Logic : ILogic
    {
        public double Calculations(string equation)
        {
            double result = 0;
            if (equation.Contains("+"))
            {
                var numbers = equation.Split('+');
                for (int i = 0; i < numbers.Length; i++)
                {
                    result += int.Parse(numbers[i]);
                }
            }
            else if (equation.Contains("-"))
            {
                var numbers = equation.Split('-');
                result = int.Parse(numbers[0]);

                for (int i = 1; i < numbers.Length; i++)
                {
                    result -= int.Parse(numbers[i]);
                }
            }
            else if (equation.Contains("*"))
            {
                var numbers = equation.Split('*');
                result += int.Parse(numbers[0]);

                for (int i = 1; i < numbers.Length; i++)
                {
                    result *= int.Parse(numbers[i]);
                }
            }
            else if (equation.Contains("/"))
            {
                var numbers = equation.Split('/');
                result += int.Parse(numbers[0]);

                for (int i = 1; i < numbers.Length; i++)
                {
                    result /= int.Parse(numbers[i]);
                }
            }
            else if (equation.Contains("root"))
            {
                var numbers = equation.Split(new char[] { 'r', 'o', 'o', 't' });

                var firstNumber = int.Parse(numbers[4]);

                result = Math.Sqrt(firstNumber);
            }

            return result;
        }

        public void ClearCalculations(Label labelToClear, TextBox textToClear)
        {
            labelToClear.Text = "Result: ";
            textToClear.Text = "";
        }

        public void SavingEquation(Button button, TextBox textToSave)
        {
            textToSave.Text += button.Text;
        }
    }

    public interface ILogic
    {
        double Calculations(string equation);
        void ClearCalculations(Label labelToClear, TextBox textToClear);
        void SavingEquation(Button button, TextBox textToSave);
    }
}