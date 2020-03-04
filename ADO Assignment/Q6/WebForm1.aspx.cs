using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void show()
        {
            String cs = ConfigurationManager.ConnectionStrings["form"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();



            
                SqlCommand cmd = new SqlCommand("Select * from TBL_EMPLOYEES", con);
                
                
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                

            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String cs = ConfigurationManager.ConnectionStrings["form"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlTransaction tr = con.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("update TBL_EMPLOYEES set EMP_SALARY=EMP_SALARY+1000 where EMP_ID=101", con,tr);
                cmd.ExecuteNonQuery();
                 cmd = new SqlCommand("update TBL_EMPLOYEES set EMP_SALARY=EMP_SALARY+1000 where EMP_ID=103", con, tr);
                cmd.ExecuteNonQuery();
                tr.Commit();
                Label1.Text = "committed";

            }
            catch
            {
                tr.Rollback();
                Label1.Text = "Transaction failed";
            }
            finally
            {
                con.Close();
            }
            show();
        }
    }
}