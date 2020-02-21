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
        ///This function returns an Employee object that contains that values for the properties of the object 
        /// </summary>
        
        public Employee add_to_obj()
        {


            Employee obj = new Employee();
            obj.fname = firstname_textbox.Text;
            obj.lname = lastname_textbox.Text;
                     obj.state = state_textbox.Text;
            obj.city = city_textbox.Text;
            try
            {
                obj.eid = int.Parse(employeeid_text.Text);

                obj.phne_number = long.Parse(phnenumber_textbox.Text);
            }
            catch (Exception)
            {

            }
            if (male_radiobutton.Checked)
                obj.gender = male_radiobutton.Text;
            else
                obj.gender = female_radiobutton.Text;
            return obj;



        }


        //This function get executed when the submit button is clicked
        private void submit_button_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj = add_to_obj();
            obj.add();
            MessageBox.Show("Added successfully");
            clearentries();
        }

        //This function clears the entries of the form
        private void clearentries()
        {
            firstname_textbox.Clear();
            lastname_textbox.Clear();
            phnenumber_textbox.Clear();
            state_textbox.Clear();
            city_textbox.Clear();
            employeeid_text.Clear();
            male_radiobutton.Checked = false;
            female_radiobutton.Checked = false;
        }

        //This function gets executed when the view button is clicked
        private void view_button_Click(object sender, EventArgs e)
        {
            Employee ee = new Employee();
            DataTable dt = new DataTable();
            dt = ee.get();
            outputgrid.DataSource = dt;
        }


        //This function is called when the delete button is clicked
        private void delete_button_Click(object sender, EventArgs e)
        {
            Employee ee = new Employee();
            ee.delete(int.Parse(employeeid_text.Text));
            MessageBox.Show("deleted sucessfully");
        }


        //This function is called when the update button is clicked
        private void update_button_Click(object sender, EventArgs e)
        {
            Employee ee = new Employee();
            ee = add_to_obj();
            ee.update();
            MessageBox.Show("updated successfully");
        }
    }
    public class Employee
    {
        public int eid { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }

        public long phne_number { get; set; }

        public string gender { get; set; }

        public string state { get; set; }

        public string city { get; set; }

        SqlHelperClass obj = new SqlHelperClass();


        
        // This function returns a datatable that contains the databse
        public DataTable get()
        {
            
            
             obj.Openconnection();
             DataTable t = new DataTable();
             t=obj.SqlAdapter();
             obj.Closeconnection();
             return t;
        }


        //This function is uesd to add the values from the entries tot he database
        public void add()
        {

            
            obj.Openconnection();

            int i = obj.ExecuteScaler(obj.Addparameterforinsert(this));
            MessageBox.Show(i.ToString());
            obj.Closeconnection();
            
           
        }

        //This function is used to delete a row from the database
        public void delete(int eid)
        {

           


            
            obj.Openconnection();
           
            obj.ExecuteNonquery(obj.Addparameterfordelete(eid),"deletefrom");
            obj.Closeconnection();
            

        }

        //This function is used to update a particular entry in the database
        public void update()
        {
           
            obj.Openconnection();
            obj.ExecuteNonquery(obj.Addparameterforupdate(this),"update");
            obj.Closeconnection();
            


        }
    }
}
