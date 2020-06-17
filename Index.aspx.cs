using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio2
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Usuario"] = "Daniel Jacamo";
        }

        protected void LogOn(object sender, EventArgs e)
        {
            if (Usuario.Text.Equals("Daniel") && Contra.Text.Equals("Jacamo"))
            {
                Response.Redirect("Calculadora.aspx");
            }
        }
    }
}