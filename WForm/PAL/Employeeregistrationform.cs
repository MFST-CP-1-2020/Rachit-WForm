using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DTO;
namespace PAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EmployeeBAL emp = new EmployeeBAL();
        

        private void Form5_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        ///This function returns an Employee object that contains the values for the properties of the object 
        /// </summary>
        public EmployeeDTO add_to_SqlHelperobj()
        {


            EmployeeDTO SqlHelperobj = new EmployeeDTO();
            SqlHelperobj.fname = txt_Firstname.Text;
            SqlHelperobj.lname = txt_Lastname.Text;
            SqlHelperobj.state = txt_State.Text;
            SqlHelperobj.city = txt_City.Text;
            try
            {
                SqlHelperobj.eid = int.Parse(txt_Employeeid.Text);
            }
            catch(Exception)
            {

            }

             try
                { 
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

            EmployeeBAL SqlHelperobj = new EmployeeBAL();
            SqlHelperobj.addusingDAL(add_to_SqlHelperobj());
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

        
       
        private void bttn_view_Click(object sender, EventArgs e)
        {
            EmployeeBAL ee = new EmployeeBAL();
            
            
            DataTable dt = new DataTable();
            dt = ee.get();
            grid_output.DataSource = dt;
        }

        private void bttn_delete_Click(object sender, EventArgs e)
        {
            EmployeeBAL ee = new EmployeeBAL();
            ee.delete(int.Parse(txt_Employeeid.Text));
            MessageBox.Show("deleted sucessfully");

        }

        private void bttn_update_Click(object sender, EventArgs e)
        {
            EmployeeBAL ee = new EmployeeBAL();
            ee.update(add_to_SqlHelperobj());
            MessageBox.Show("updated successfully");
            
        }
    }
}
