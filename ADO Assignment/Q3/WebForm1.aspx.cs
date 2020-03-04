using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String cs = ConfigurationManager.ConnectionStrings["form"].ConnectionString;
            SqlConnection con = null;


            using (con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select * from TBL_EMPLOYEES", con);
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                con.Close();

                cmd = new SqlCommand("Select count(*) FROM TBL_EMPLOYEES", con);
                con.Open();
                int store = (int)cmd.ExecuteScalar();
                Response.Write("Total" + store.ToString() + "</br>");
                con.Close();

                cmd = new SqlCommand("Insert into TBL_EMPLOYEES(EMP_NAME) VALUES('Vivek')", con);
                con.Open();
                int inserted = cmd.ExecuteNonQuery();
                Response.Write("TOTAL ROWS AFFECTED" + inserted.ToString());

            }

        }
    }
}