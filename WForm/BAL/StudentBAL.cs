using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;
namespace BAL
{
    public class StudentBAL
    {
        public int sid { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }

        public long phne_number { get; set; }

        public string gender { get; set; }

        public string state { get; set; }

        public string city { get; set; }

        SqlHelperClass SqlHelperobj = new SqlHelperClass();



        /// <summary>
        ///  This function returns a datatable that contains the databse
        /// </summary>
        public DataTable get()
        {

            DataTable t = new DataTable();
            t = SqlHelperobj.SqlAdapter("getstudent");
            return t;

        }

        /// <summary>
        /// This function is uesd to add the values from the entries tot he database
        /// </summary>
        public void add()
        {


            Addparameterforinsert();
            int i = SqlHelperobj.ExecuteScaler("insertintousingscalarstudent");
            
     
        }


        /// <summary>
        /// This function adds the paramters to a SqlCommand object and returns that object
        /// </summary>
        /// <param name="e"> An Employee object that contains the values to be added</param>
        /// <returns>A SqlCommand Object that contains the needed paramters</returns>
        public void Addparameterforinsert()
        {

            string fname = "@Firstname";
            string lname = "@Lastname";
            string phnenum = "@Phone_number";
            string state = "@State";
            string city = "@City";
            string gender = "@Gender";

            SqlHelperobj.Parameter(fname, SqlDbType.NVarChar, this.fname, ParameterDirection.Input);
            SqlHelperobj.Parameter(lname, SqlDbType.NVarChar, this.lname, ParameterDirection.Input);
            SqlHelperobj.Parameter(phnenum, SqlDbType.BigInt, this.phne_number, ParameterDirection.Input);
            SqlHelperobj.Parameter(state, SqlDbType.NVarChar, this.state, ParameterDirection.Input);
            SqlHelperobj.Parameter(city, SqlDbType.NVarChar, this.city, ParameterDirection.Input);
            SqlHelperobj.Parameter(gender, SqlDbType.NVarChar, this.gender, ParameterDirection.Input);
        }


        /// <summary>
        /// This function is used to delete a row from the database
        /// </summary>
        /// <param name="eid"> The id of the Employee who's data we wish to delete from the database</param>
        public void delete(int eid)
        {

            Addparameterfordelete(eid);
            SqlHelperobj.ExecuteNonquery("deletefromstudent");

        }
        /// <summary>
        /// adds Employeeid parameter to the cmd object to delete that from the database
        /// </summary>
        /// <param name="e">The Employeeid of the Employee who's data we wish to delete from the database</param>
        /// <returns> A SqlCommand object that contains the Employeeid parameter</returns>
        public void Addparameterfordelete(int e)
        {
            string sid = "@Studentid";
            SqlHelperobj.Parameter(sid, SqlDbType.Int, e, ParameterDirection.Input);

        }
        /// <summary>
        /// This function is used to update a particular entry in the database
        /// </summary>
        public void update()
        {
            Addparameterforupdate(this);
            SqlHelperobj.ExecuteNonquery("updatefromstudent");
        }
        /// <summary>
        /// adds 7 parameters to the cmd object to update the value in the database
        /// </summary>
        /// <param name="e">Employee object that contains the values that are to updated in the database</param>
        /// <returns>a SqlCommand object that contains the required parameters</returns>
        public void Addparameterforupdate(StudentBAL e)
        {
            string sid = "@Studentid";
            string fname = "@Firstname";
            string lname = "@Lastname";
            string phnenum = "@Phone_number";
            string state = "@State";
            string city = "@City";
            string gender = "@Gender";
            SqlHelperobj.Parameter(sid, SqlDbType.Int, e.sid, ParameterDirection.Input);
            SqlHelperobj.Parameter(fname, SqlDbType.NVarChar, e.fname, ParameterDirection.Input);
            SqlHelperobj.Parameter(lname, SqlDbType.NVarChar, e.lname, ParameterDirection.Input);
            SqlHelperobj.Parameter(phnenum, SqlDbType.BigInt, e.phne_number, ParameterDirection.Input);
            SqlHelperobj.Parameter(state, SqlDbType.NVarChar, e.state, ParameterDirection.Input);
            SqlHelperobj.Parameter(city, SqlDbType.NVarChar, e.city, ParameterDirection.Input);
            SqlHelperobj.Parameter(gender, SqlDbType.NVarChar, e.gender, ParameterDirection.Input);

        }

    }
}
