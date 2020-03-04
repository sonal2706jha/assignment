using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DemoWebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "hello ttn";
            if(!IsPostBack)
            {
                // DropDownList2.Items.Add("Unkown");
                //DropDownList2.Items.Add("Trans");
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("Countries.xml"));
                DropDownList2.DataTextField = "CountryName";
                DropDownList2.DataValueField = "CountryName";
                DropDownList2.DataSource = ds;
                DropDownList2.DataBind();
                ListItem li = new ListItem("Select", "-1");
                DropDownList2.Items.Insert(0,li);
    





            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList2.SelectedValue;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx?UserName"+Server.UrlEncode(TextBox1.Text));
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}