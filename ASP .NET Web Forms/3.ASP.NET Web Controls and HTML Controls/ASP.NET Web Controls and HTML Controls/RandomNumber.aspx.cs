using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Web_Controls_and_HTML_Controls
{
    public partial class RandomNumber : System.Web.UI.Page
    {
        private readonly IGenerator generator;

        public RandomNumber()
        {
            this.generator = new Generator();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_click(object sender, EventArgs e)
        {
            var result = this.generator.GenerateRandomNumber(int.Parse(this.firstNumber.Value), int.Parse(this.secondNumber.Value));
            this.generatedNumber.InnerText = result.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var result = this.generator.GenerateRandomNumber(int.Parse(this.First.Text), int.Parse(this.Second.Text));
            this.Label1.Text = result.ToString();
        }
    }

    public class Generator : IGenerator
    {
        public int GenerateRandomNumber(int firstNumber, int secondNumber)
        {
            Random random = new Random();
            return random.Next(firstNumber, secondNumber);
        }
    }

    public interface IGenerator
    {
        int GenerateRandomNumber(int firstNumber, int secondNumber);
    }
}