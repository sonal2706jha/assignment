using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q8
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
                SqlCommand cmd = new SqlCommand("Insert into Detail values(@Detail_Name,@Detail_Password,@Detail_City,@Detail_Gender)", connection);



                cmd.Parameters.AddWithValue("@Detail_Name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Detail_Password", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Detail_City", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@Detail_Gender", RadioButtonList1.SelectedValue);
                cmd.ExecuteNonQuery();
                connection.Close();


            }
        }
    }
}