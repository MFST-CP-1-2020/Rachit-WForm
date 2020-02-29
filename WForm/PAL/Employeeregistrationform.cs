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
        public EmployeeDTO add_to_DTOobj()
        {


            EmployeeDTO employeebalobj = new EmployeeDTO();
            employeebalobj.fname = txt_Firstname.Text;
            employeebalobj.lname = txt_Lastname.Text;
            employeebalobj.state = txt_State.Text;
            employeebalobj.city = txt_City.Text;
            try
            {
                employeebalobj.eid = int.Parse(txt_Employeeid.Text);
            }
            catch(Exception)
            {

            }

             try
                { 
                employeebalobj.phne_number = long.Parse(txt_Phonenumber.Text);
            }
            catch (Exception)
            {

            }
            if (radiobttn_Male.Checked)
                employeebalobj.gender = radiobttn_Male.Text;
            else
                employeebalobj.gender = radiobttn_Female.Text;
            return employeebalobj;



        }


        /// <summary>
        /// This function get executed when the submit button is clicked
        /// </summary>
        private void submit_button_Click(object sender, EventArgs e)
        {

            EmployeeBAL employeebalobj = new EmployeeBAL();
            employeebalobj.addusingDAL(add_to_DTOobj());
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
            EmployeeBAL employeebalobj = new EmployeeBAL();
            
            
            DataTable dt = new DataTable();
            dt = employeebalobj.get();
            grid_output.DataSource = dt;
        }

        private void bttn_delete_Click(object sender, EventArgs e)
        {
            EmployeeBAL employeebalobj = new EmployeeBAL();
            employeebalobj.delete(int.Parse(txt_Employeeid.Text));
            MessageBox.Show("deleted sucessfully");

        }

        private void bttn_update_Click(object sender, EventArgs e)
        {
            EmployeeBAL employeebalobj = new EmployeeBAL();
            employeebalobj.update(add_to_DTOobj());
            MessageBox.Show("updated successfully");
            
        }
    }
}
