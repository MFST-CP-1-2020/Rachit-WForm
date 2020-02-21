using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WForm.EventAndDelegate
{
    public class SHL
    {
        SqlConnection conn;
        SqlCommand comm;
        string connstring = @"database=TestDB;server=RACHIT-PC\SQLEXPRESS;User Id=sa;Password=mindfire@1";
        public SHL()
        {
            //string connstring = @"database=TestDB;server=RACHIT-PC\SQLEXPRESS;User Id=sa;Password=mindfire@1";
            conn = new SqlConnection(connstring);
            comm = new SqlCommand();
            comm.Connection = conn;

        }
                
        public void parameter(string parameter_name,string datatype,string value)
        {

            comm.Parameters.Add(parameter_name, System.Data.SqlDbType.NVarChar);
            comm.Parameters[parameter_name].Value = value;

        }

        public void openconnection()
        {
            conn.Open();
        }
        public  void closeconnection()
        {
            conn.Close();
        }
        public int executescaler(string query)
        {

            comm.CommandText = query;
           Int32 res = (Int32)comm.ExecuteScalar();
            return (int)res;
        }
        public void ExecuteNonquery(string query)
        {
            comm.CommandText = query;
            comm.ExecuteNonQuery();
        }
        public DataTable sqladapter()
        {
            SqlDataAdapter a = new SqlDataAdapter("select * from Employee", conn);
            DataTable t = new DataTable();
            a.Fill(t);
            return t;
        }

        
    }
}
