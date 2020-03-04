using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ADO_Assignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["form"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
                connection.ConnectionString = "data source=.; database=BOOTCAMP2020;user id=sa;password=sonal;Connection Timeout=15;Connection lifetime=0;Min Pool size=100;Pooling=true;";


            {
                try
                {


                    switch (TextBox1.Text)
                    {
                        case "1":
                            using (SqlConnection con = new SqlConnection(connectionString))
                            {
                                SqlCommand cmd = new SqlCommand("Select * from TBL_EMPLOYEES;Select EMP_NAME FROM TBL_EMPLOYEES", con);
                                con.Open();
                                SqlDataReader rd = cmd.ExecuteReader();
                                GridView1.DataSource = rd;
                                GridView1.DataBind();

                                while (rd.NextResult())
                                {
                                    GridView2.DataSource = rd;
                                    GridView2.DataBind();
                                }
                            }
                            break;

                        case "2":

                            SqlDataAdapter ad = new SqlDataAdapter("Select * from TBL_EMPLOYEES", connectionString);
                            DataSet ds = new DataSet();
                            ad.Fill(ds);
                            GridView3.DataSource = ds;
                            GridView3.DataBind();
                            break;
                        default:
                            Console.WriteLine("invalid input");
                            break;


                    }
                }
                catch(Exception )
                {
                    Response.Write("done");
                }





            }
        }
    }
}
