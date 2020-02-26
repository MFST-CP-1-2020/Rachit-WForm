using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class SqlHelperClass
    {
        SqlConnection conn;
        List<SqlParameter> parameter_list;
        string connstring = @"database=TestDB;server=RACHIT-PC\SQLEXPRESS;User Id=sa;Password=mindfire@1";

        /// <summary>
        /// This constructor is used to initialize the connection object of the SqlHelperClass
        /// </summary>
        public SqlHelperClass()
        {
            conn = new SqlConnection(connstring);
            parameter_list = new List<SqlParameter>();
        }
        /// <summary>
        /// This function adds parameter to the sqlcommand object comm
        /// </summary>

        public void Parameter(string parameter_name, SqlDbType datatype, object value, ParameterDirection direction)
        {
            SqlParameter parameterobj = new SqlParameter();
            parameterobj.ParameterName = parameter_name;
            parameterobj.SqlDbType = datatype;
            parameterobj.Value = value;
            parameterobj.Direction = direction;
            parameter_list.Add(parameterobj);

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
        public int ExecuteScaler(string s)
        {
            Openconnection();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = s;
            comm.Parameters.AddRange(parameter_list.ToArray());
            Int32 res = Convert.ToInt32(comm.ExecuteScalar());
            Closeconnection();
            parameter_list.Clear();
            return (int)res;
        }

        /// <summary>
        ///This function executes the stored procedure that is passed to it as parameter using ExecuteNonQuery() 
        /// </summary>
        public void ExecuteNonquery(string commandText)
        {
            Openconnection();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = commandText;
            comm.Parameters.AddRange(parameter_list.ToArray());
            comm.ExecuteNonQuery();
            //MessageBox.Show("Executed");
            Closeconnection();
        }

        /// <summary>
        /// This function is used to execute the stored procedure get and returns a datatable that contains the result returned from executing the query 
        /// </summary>
        public DataTable SqlAdapter(string s)
        {
            Openconnection();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = s;
            SqlDataAdapter a = new SqlDataAdapter(comm);
            DataTable t = new DataTable();
            a.Fill(t);
            Closeconnection();
            return t;
        }


    }

}
