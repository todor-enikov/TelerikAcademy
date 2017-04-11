using ASP.NETDataBinding._1.Task_SearchingForCar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETDataBinding
{
    public partial class SearchingForCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                return;
            }

            var producers = new List<Producer>()
            {
                new Producer("BMW", new List<string>() {"114", "116", "118", "120", "123", "125", "130" }),
                new Producer("LADA", new List<string>() {"1200", "1300", "1500", "2105", "2107", "Samara", "Niva" }),
                new Producer("Mercedes", new List<string>() {"124", "E220", "E200", "S-Class", "M-Class", "G-Class", "G-Class 6x6" }),
                new Producer("Zastava", new List<string>() {"600", "750", "Florida", "Gt-55", "Koral", "Miami", "Yugo 45" })
            };

            var listOfExtras = new List<string>()
            {
                "DVD",
                "TV",
                "Radio",
                "El. Mirrors",
                "GPS",
                "El. windows",
                "4x4","Stereo"
            };

            var typeOfEngines = new List<string>() { "Gasoline", "Diesel", "Rocket Fuel", "Nitro glicerine", "Gaz bace!" };

            this.ProducerDropDown.DataSource = producers;
            this.ProducerDropDown.DataBind();

            if (this.ProducerDropDown.Text == "BMW")
            {
                this.ModelDropDownList.DataSource = producers[0].Models;
                this.ModelDropDownList.DataBind();
            }
            else if (this.ProducerDropDown.Text == "LADA")
            {
                this.ModelDropDownList.DataSource = producers[1].Models;
                this.ModelDropDownList.DataBind();
            }
            else if (this.ProducerDropDown.Text == "Mercedes")
            {
                this.ModelDropDownList.DataSource = producers[2].Models;
                this.ModelDropDownList.DataBind();
            }
            else
            {
                this.ModelDropDownList.DataSource = producers[3].Models;
                this.ModelDropDownList.DataBind();
            }

            this.ExtraCheckBoxList.DataSource = listOfExtras;
            this.ExtraCheckBoxList.DataBind();

            this.EngineRadioButtonList.DataSource = typeOfEngines;
            this.EngineRadioButtonList.DataBind();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            var selectedItemsFromCheckBox = this.ExtraCheckBoxList.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
            var result = new StringBuilder();
            result.Append("<label>");
            result.AppendLine("Your choice was: ");
            result.AppendLine("Producer: " + this.ProducerDropDown.SelectedValue);
            result.AppendLine("Model: " + this.ModelDropDownList.SelectedValue);
            if (this.ExtraCheckBoxList.SelectedValue!="")
            {
                result.AppendLine("With extras: " + string.Join(", ", selectedItemsFromCheckBox));
            }
            else
            {
                result.AppendLine("No extras");
            }
            if (this.EngineRadioButtonList.SelectedValue!="")
            {
                result.AppendLine("and it's type is: " + this.EngineRadioButtonList.SelectedValue);
            }
            else
            {
                result.AppendLine("and does not have type!");
            }
            result.Append("</label>");
            this.ChoosenInfo.Text = result.ToString();
        }
    }
}