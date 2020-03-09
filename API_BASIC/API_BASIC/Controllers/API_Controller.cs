using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using API_BASIC.Models;

namespace API_BASIC.Controllers
{
    public class API_Controller : ApiController
    {
        Models.Table table = new Models.Table();
        
       //Table t = new Table();


            //get all data.......
        [HttpGet]
        public DataSet GetAllData()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["form"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * from TBL_EMPLOYEES", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
        }

/// //////////////////////////////////////////////////////////////////////////////////////////////////
        //Get one data by using where condition.

        [HttpPost]
        public DataSet GetOneData(Models.Table table)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["form"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * from TBL_EMPLOYEES where @EMP_ID=EMP_ID", con);
                cmd.Parameters.AddWithValue("@EMP_ID", table.EMP_ID);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
        }
        //..................................................................................................................
        //To insert data by using insert keyword
        [HttpPost]
        public bool insertdata(Models.Table table)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["form"].ConnectionString))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into TBL_EMPLOYEES (EMP_ID) VALUES (@EMP_ID)", con);
                cmd.Parameters.AddWithValue("@EMP_ID",table.EMP_ID);

                int r = cmd.ExecuteNonQuery();
                if (r == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        //.............................................................................................................
        //To update data
        [HttpPut]
        public DataSet GetDataUpdate(Models.Table table)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["form"].ConnectionString))
            {
                string sqlQuery = "Select * from TBL_EMPLOYEES where @EMP_ID = EMP_ID";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                cmd.Parameters.AddWithValue("@EMP_ID", table.EMP_ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            
        }

        //............................................................................................
        //to delete data

        [HttpDelete]
        public DataSet GetDataDelete(Models.Table table)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["form"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Delete from TBL_EMPLOYEES where @EMP_ID=EMP_ID", con);
                cmd.Parameters.AddWithValue("@EMP_ID", table.EMP_ID);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
    }

}
    

