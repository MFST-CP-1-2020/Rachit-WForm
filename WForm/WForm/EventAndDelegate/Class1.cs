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
        public SqlHelperClass()
        {
            conn = new SqlConnection(connstring);
          
        }
                //This function adds parameter to the sqlcommand object comm
        public void Parameter(SqlCommand comm,string parameter_name,SqlDbType datatype,object value,ParameterDirection direction)
        {
            
            comm.Parameters.Add(parameter_name, datatype);
            comm.Parameters[parameter_name].Value = value;
            comm.Parameters[parameter_name].Direction = direction;
            
          }

        //this function adds the parameters to the command sqlcommand object
        public SqlCommand Addparameterforinsert(Employee e)
        {
            SqlCommand cmd = new SqlCommand();
            
            string fname = "@Firstname";
            string lname = "@Lastname";
            string phnenum = "@Phone_number";
            string state = "@State";
            string city = "@City";
            string gender = "@Gender";
            
            Parameter(cmd, fname, SqlDbType.NVarChar, e.fname, ParameterDirection.Input);
            Parameter(cmd, lname, SqlDbType.NVarChar, e.lname, ParameterDirection.Input);
            Parameter(cmd, phnenum, SqlDbType.BigInt, e.phne_number, ParameterDirection.Input);
            Parameter(cmd, state, SqlDbType.NVarChar, e.state, ParameterDirection.Input);
            Parameter(cmd, city, SqlDbType.NVarChar, e.city, ParameterDirection.Input);
            Parameter(cmd, gender, SqlDbType.NVarChar, e.gender, ParameterDirection.Input);
            return cmd;
        }

        //adds Employeeid parameter to the cmd object to delete that from the database
        public SqlCommand Addparameterfordelete(int e)
        {
            SqlCommand cmd = new SqlCommand();
            string eid = "@Employeeid";
            Parameter(cmd, eid, SqlDbType.Int, e, ParameterDirection.Input);

            return cmd;
        }



        //adds 7 parameters to the cmd object to update the value in the database
        public SqlCommand Addparameterforupdate(Employee e)
        {
            SqlCommand cmd = new SqlCommand();
            string eid = "@Employeeid";
            string fname = "@Firstname";
            string lname = "@Lastname";
            string phnenum = "@Phone_number";
            string state = "@State";
            string city = "@City";
            string gender = "@Gender";
            Parameter(cmd, eid, SqlDbType.Int, e.eid, ParameterDirection.Input);
            Parameter(cmd, fname, SqlDbType.NVarChar, e.fname, ParameterDirection.Input);
            Parameter(cmd, lname, SqlDbType.NVarChar, e.lname, ParameterDirection.Input);
            Parameter(cmd, phnenum, SqlDbType.BigInt, e.phne_number, ParameterDirection.Input);
            Parameter(cmd, state, SqlDbType.NVarChar, e.state, ParameterDirection.Input);
            Parameter(cmd, city, SqlDbType.NVarChar, e.city, ParameterDirection.Input);
            Parameter(cmd, gender, SqlDbType.NVarChar, e.gender, ParameterDirection.Input);
            return cmd;

        }

        //opens the connection
        public void Openconnection()
        {
            conn.Open();
        }


        //closes the conncetion
        public  void Closeconnection()
        {
            conn.Close();
        }
        public int ExecuteScaler(SqlCommand comm)
        {
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "insertintousingscalar";
           Int32 res = Convert.ToInt32(comm.ExecuteScalar());
            return (int)res;
        }
        public void ExecuteNonquery(SqlCommand comm,string commandText)
        {
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = commandText;
            comm.ExecuteNonQuery();
            MessageBox.Show("Executed");
        }
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
