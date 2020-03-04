using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Q7
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
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Insert into employee(EMP_ID,EMP_NAME,EMP_DOB) values(@EMP_ID,@EMP_NAME,@EMP_DOB)", connection);

               
                
                cmd.Parameters.AddWithValue("@EMP_ID", TextBox1.Text);
                cmd.Parameters.AddWithValue("@EMP_NAME", TextBox2.Text);
                cmd.Parameters.AddWithValue("@EMP_DOB", TextBox4.Text);
                cmd.ExecuteNonQuery();
                connection.Close();


            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("Button click");
        }

       
        protected void Button2_Command1(object sender, CommandEventArgs e)
        {
            Response.Write("Button click");
        }
    }
}
