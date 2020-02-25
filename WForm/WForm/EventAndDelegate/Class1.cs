using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WForm.EventAndDelegate
{
    /// <summary>
    /// This class provides functions for Addparameter,executenonquery,sqldataadpater,executescalar
    /// </summary>
    public class SqlHelperClass
    {
        SqlConnection conn;
        
        string connstring = @"database=TestDB;server=RACHIT-PC\SQLEXPRESS;User Id=sa;Password=mindfire@1";

        /// <summary>
        /// This constructor is used to initialize the connection object of the SqlHelperClass
        /// </summary>
        public SqlHelperClass()
        {
            conn = new SqlConnection(connstring);
          
        }
        /// <summary>
        /// This function adds parameter to the sqlcommand object comm
        /// </summary>
     
        public void Parameter(SqlCommand comm,string parameter_name,SqlDbType datatype,object value,ParameterDirection direction)
        {
            
            comm.Parameters.Add(parameter_name, datatype);
            comm.Parameters[parameter_name].Value = value;
            comm.Parameters[parameter_name].Direction = direction;
            
          }





        /// <summary>
        /// opens the connection
        /// </summary>
        public void Openconnection()
        {
            conn.Open();
        }


        /// <summary>
        /// closes the conncetion
        /// </summary>
        public void Closeconnection()
        {
            conn.Close();
        }

        /// <summary>
        /// This function executes the stored procedure insertintousingscalar and returns the PK of the newly added row
        /// </summary>
        public int ExecuteScaler(SqlCommand comm)
        {
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "insertintousingscalar";
           Int32 res = Convert.ToInt32(comm.ExecuteScalar());
            return (int)res;
        }

        /// <summary>
        ///This function executes the stored procedure that is passed to it as parameter using ExecuteNonQuery() 
        /// </summary>
        public void ExecuteNonquery(SqlCommand comm,string commandText)
        {
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = commandText;
            comm.ExecuteNonQuery();
            MessageBox.Show("Executed");
        }

        /// <summary>
        /// This function is used to execute the stored procedure get and returns a datatable that contains the result returned from executing the query 
        /// </summary>
        public DataTable SqlAdapter()
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "get";
            SqlDataAdapter a = new SqlDataAdapter(comm);
            DataTable t = new DataTable();
            a.Fill(t);
            return t;
        }

        
    }
}
