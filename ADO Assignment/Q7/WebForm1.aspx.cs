using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
            protected void Page_Load(object sender, EventArgs e)
            {
                Response.Write("improve system performance cache");
            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                string CS = ConfigurationManager.ConnectionStrings["form"].ConnectionString;
                if (Cache["Stock"] == null)
                {
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlDataAdapter da = new SqlDataAdapter("select * from TBL_EMPLOYEES", con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        GridView1.DataSource = ds;
                        GridView1.DataBind();

                        Cache["Stock"] = ds;
                        Label1.Text = "data came from database";

                    }
                }
                else
                {

                    GridView2.DataSource = (DataSet)Cache["Stock"];
                    GridView2.DataBind();
                    Label1.Text = "Cache data recieved";
                }
            }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
    }
   