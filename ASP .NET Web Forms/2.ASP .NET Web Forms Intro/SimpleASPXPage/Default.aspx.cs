using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleASPXPage
{
    public partial class _Default : Page
    {
        private readonly IFillingText fill;
        public _Default()
        {
            this.fill = new FillingText();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            var result = this.fill.Fill(this.TextBox.Text);
            this.FinalText.Text = result;
        }
    }

    public class FillingText : IFillingText
    {
        public string Fill(string text)
        {
            return "Hello " + text;
        }
    }

    public interface IFillingText
    {
        string Fill(string text);
    }
}