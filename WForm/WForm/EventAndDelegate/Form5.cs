using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WForm.EventAndDelegate
{
    public partial class Form5 : Form
    {
        Employee emp = new Employee();
        public Form5()
        {
            InitializeComponent();
        }


        private void Form5_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        ///This function returns an Employee object that contains the values for the properties of the object 
        /// </summary>
        public Employee add_to_SqlHelperobj()
        {


            Employee SqlHelperobj = new Employee();
            SqlHelperobj.fname = txt_Firstname.Text;
            SqlHelperobj.lname = txt_Lastname.Text;
                     SqlHelperobj.state = txt_State.Text;
            SqlHelperobj.city = txt_City.Text;
            try
            {
                SqlHelperobj.eid = int.Parse(txt_Employeeid.Text);

                SqlHelperobj.phne_number = long.Parse(txt_Phonenumber.Text);
            }
            catch (Exception)
            {

            }
            if (radiobttn_Male.Checked)
                SqlHelperobj.gender = radiobttn_Male.Text;
            else
                SqlHelperobj.gender = radiobttn_Female.Text;
            return SqlHelperobj;



        }


        /// <summary>
        /// This function get executed when the submit button is clicked
        /// </summary>
        private void submit_button_Click(object sender, EventArgs e)
        {
            Employee SqlHelperobj = new Employee();
            SqlHelperobj = add_to_SqlHelperobj();
            SqlHelperobj.add();
            MessageBox.Show("Added successfully");
            clearentries();
        }

        /// <summary>
        /// This function clears the entries of the form
        /// </summary>
        private void clearentries()
        {
            txt_Firstname.Clear();
            txt_Lastname.Clear();
            txt_Phonenumber.Clear();
            txt_State.Clear();
            txt_City.Clear();
            txt_Employeeid.Clear();
            radiobttn_Male.Checked = false;
            radiobttn_Female.Checked = false;
        }

        /// <summary>
        /// This function gets executed when the view button is clicked
        /// </summary>
        private void view_button_Click(object sender, EventArgs e)
        {
            Employee ee = new Employee();
            DataTable dt = new DataTable();
            dt = ee.get();
            grid_output.DataSource = dt;
        }


        /// <summary>
        /// This function is called when the delete button is clicked
        /// </summary>
        private void delete_button_Click(object sender, EventArgs e)
        {
            Employee ee = new Employee();
            ee.delete(int.Parse(txt_Employeeid.Text));
            MessageBox.Show("deleted sucessfully");
        }

        /// <summary>
        /// This function is called when the update button is clicked
        /// </summary>
        private void update_button_Click(object sender, EventArgs e)
        {
            Employee ee = new Employee();
            ee = add_to_SqlHelperobj();
            ee.update();
            MessageBox.Show("updated successfully");
        }
    }


    /// <summary>
    /// This class contains the properties of an Employee and thee various function that are needed to perform the desired operations
    /// </summary>
    public class Employee
    {
        public int eid { get; set; }
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
            
            
             SqlHelperobj.Openconnection();
             DataTable t = new DataTable();
             t=SqlHelperobj.SqlAdapter();
             SqlHelperobj.Closeconnection();
             return t;
        }

        /// <summary>
        /// This function is uesd to add the values from the entries tot he database
        /// </summary>
        public void add()
        {

            
            SqlHelperobj.Openconnection();

            int i = SqlHelperobj.ExecuteScaler(Addparameterforinsert(this));
            MessageBox.Show(i.ToString());
            SqlHelperobj.Closeconnection();
            
           
        }


        /// <summary>
        /// This function adds the paramters to a SqlCommand object and returns that object
        /// </summary>
        /// <param name="e"> An Employee object that contains the values to be added</param>
        /// <returns>A SqlCommand Object that contains the needed paramters</returns>
        public SqlCommand Addparameterforinsert(Employee e)
        {
            SqlCommand cmd = new SqlCommand();

            string fname = "@Firstname";
            string lname = "@Lastname";
            string phnenum = "@Phone_number";
            string state = "@State";
            string city = "@City";
            string gender = "@Gender";

            SqlHelperobj.Parameter(cmd, fname, SqlDbType.NVarChar, e.fname, ParameterDirection.Input);
            SqlHelperobj.Parameter(cmd, lname, SqlDbType.NVarChar, e.lname, ParameterDirection.Input);
            SqlHelperobj.Parameter(cmd, phnenum, SqlDbType.BigInt, e.phne_number, ParameterDirection.Input);
            SqlHelperobj.Parameter(cmd, state, SqlDbType.NVarChar, e.state, ParameterDirection.Input);
            SqlHelperobj.Parameter(cmd, city, SqlDbType.NVarChar, e.city, ParameterDirection.Input);
            SqlHelperobj.Parameter(cmd, gender, SqlDbType.NVarChar, e.gender, ParameterDirection.Input);
            return cmd;
        }


        /// <summary>
        /// This function is used to delete a row from the database
        /// </summary>
        /// <param name="eid"> The id of the Employee who's data we wish to delete from the database</param>
        public void delete(int eid)
        {
            SqlHelperobj.Openconnection();  
            SqlHelperobj.ExecuteNonquery(Addparameterfordelete(eid),"deletefrom");
            SqlHelperobj.Closeconnection();
        }
        /// <summary>
        /// adds Employeeid parameter to the cmd object to delete that from the database
        /// </summary>
        /// <param name="e">The Employeeid of the Employee who's data we wish to delete from the database</param>
        /// <returns> A SqlCommand object that contains the Employeeid parameter</returns>
        public SqlCommand Addparameterfordelete(int e)
        {
            SqlCommand cmd = new SqlCommand();
            string eid = "@Employeeid";
            SqlHelperobj.Parameter(cmd, eid, SqlDbType.Int, e, ParameterDirection.Input);

            return cmd;
        }
        /// <summary>
        /// This function is used to update a particular entry in the database
        /// </summary>
        public void update()
        {
            SqlHelperobj.Openconnection();
            SqlHelperobj.ExecuteNonquery(Addparameterforupdate(this),"update");
            SqlHelperobj.Closeconnection();
        }
        /// <summary>
        /// adds 7 parameters to the cmd object to update the value in the database
        /// </summary>
        /// <param name="e">Employee object that contains the values that are to updated in the database</param>
        /// <returns>a SqlCommand object that contains the required parameters</returns>
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
            SqlHelperobj.Parameter(cmd, eid, SqlDbType.Int, e.eid, ParameterDirection.Input);
            SqlHelperobj.Parameter(cmd, fname, SqlDbType.NVarChar, e.fname, ParameterDirection.Input);
            SqlHelperobj.Parameter(cmd, lname, SqlDbType.NVarChar, e.lname, ParameterDirection.Input);
            SqlHelperobj.Parameter(cmd, phnenum, SqlDbType.BigInt, e.phne_number, ParameterDirection.Input);
            SqlHelperobj.Parameter(cmd, state, SqlDbType.NVarChar, e.state, ParameterDirection.Input);
            SqlHelperobj.Parameter(cmd, city, SqlDbType.NVarChar, e.city, ParameterDirection.Input);
            SqlHelperobj.Parameter(cmd, gender, SqlDbType.NVarChar, e.gender, ParameterDirection.Input);
            return cmd;

        }

    }
}
