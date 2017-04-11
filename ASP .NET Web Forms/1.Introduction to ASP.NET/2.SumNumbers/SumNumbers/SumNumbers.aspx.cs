using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SumNumbers
{
    public partial class SumNumbers : System.Web.UI.Page
    {
        private readonly ISumator sumTwoNumbers;

        public SumNumbers()
        {
            this.sumTwoNumbers = new Sumator();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sum_Click(object sender, EventArgs e)
        {
            var result = this.sumTwoNumbers.Sum(long.Parse(this.FirstNumber.Text), long.Parse(this.SecondNumber.Text));
            this.FinalResult.Text = result.ToString();
        }

    }

    public class Sumator : ISumator
    {
        public long Sum(long firstNumber, long secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }

    public interface ISumator
    {
        long Sum(long firstNumber, long secondNumber);
    }
}