using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;


namespace Q5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String cs = ConfigurationManager.ConnectionStrings["form"].ConnectionString;
            SqlConnection con = null;


            using (con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("usp_EmployeeDetail1", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EMP_ID", TextBox1.Text);
                //cmd.Parameters.AddWithValue("@EMP_NAME", TextBox2.Text);

                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                
            }
        }
    }
}