using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace DemoWebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //string abc = null;
            //string str = abc;

            string ConnectionString = ConfigurationManager.ConnectionStrings["demo sql con"].ConnectionString;
            using (SqlConnection connection=new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * from TBL_EMPLOYEES", connection);
                connection.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
                                        
        }
    }
}