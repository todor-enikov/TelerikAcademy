using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace ASP.NETDataBinding._3.Task_XML
{
    public partial class XML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load("d:\telerik\\ASP.NET WebForms\\5.ASP.NETDataBinding\\ASP.NETDataBinding\\3.Task-XML\\Report.xml");

            var xmlContents = document.InnerXml;

            this.XmlDataSource1.Data = xmlContents;
            this.XmlDataSource1.DataBind();
        }
    }
}