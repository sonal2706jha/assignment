using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUES_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("No. of Application" + Application["Total Application"]);
            Response.Write("</br>");
            Response.Write("No. of users" + Application["Total UserSession"]);

        }
    }
}