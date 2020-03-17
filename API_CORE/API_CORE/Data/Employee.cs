using API_CORE.Models;

using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using VisioForge.Shared.MediaFoundation.OPM;

namespace API_CORE.Data
{
    public class Employee : IEmployee
    {
        private readonly IOptions<Connection> _con;

        public Employee(IOptions<Connection> con)
        {
            _con = con;
        }
        public DataSet GetData()
        {
            try
            {


                SqlConnection sqlConnection = new SqlConnection(_con.Value.ConnectionString);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("Select * from TBL_EMPLOYEES", sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                sqlConnection.Close();
                return ds;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public DataSet GetDataId(int EMP_ID)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(_con.Value.ConnectionString);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("Select * from TBL_EMPLOYEES where EMP_ID=@EMP_ID", sqlConnection);
                // cmd.Parameters.AddWithValue("@EMP_ID", E.EMP_ID);
                cmd.Parameters.AddWithValue("@EMP_ID", EMP_ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
            catch(Exception ex)
            {
                throw ex
            }

        }

        public bool InsertData(EMP E)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(_con.Value.ConnectionString);
                SqlCommand cmd = new SqlCommand("Insert into TBL_EMPLOYEES (EMP_SALARY) VALUES (@EMP_ID)", sqlConnection);
                sqlConnection.Open();
                cmd.Parameters.AddWithValue("@EMP_SALARY", E.EMP_SALARY);

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
            catch(Exception ex)
            {
                throw ex;

            }

        }

        public bool UpdateData(int EMP_ID, EMP E)
        {
            SqlConnection sqlConnection = new SqlConnection(_con.Value.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE TBL_EMPLOYEES SET  EMP_SALARY=@EMP_SALARY WHERE EMP_ID=" + EMP_ID, sqlConnection);

            cmd.Parameters.AddWithValue("@EMP_SALARY", E.EMP_SALARY);
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

        public DataSet DeleteData(EMP E)
        {
            try
            {

                SqlConnection sqlConnection = new SqlConnection(_con.Value.ConnectionString);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("Delete from TBL_EMPLOYEES where @EMP_ID=EMP_ID", sqlConnection);
                cmd.Parameters.AddWithValue("@EMP_ID", E.EMP_ID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}

