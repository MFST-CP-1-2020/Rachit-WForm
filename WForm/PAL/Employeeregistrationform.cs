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

    /// <summary>
    /// This class is present in the presentation layer of the student form and contains functions for the add,upadate,delete and get or view.Also contains a function to add values to the DTO object.
    /// </summary>
    public partial class Employeeregistrationform : Form
    {
        public Employeeregistrationform()
        {
            InitializeComponent();
        }
        EmployeeBAL emp = new EmployeeBAL();
              
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
        /// This function get executed when the submit button is clicked and passes the DTO object to the Bussiness Layer
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

       /// <summary>
       ///This function is called when the view button is clicked on the form 
       /// </summary>
        private void bttn_view_Click(object sender, EventArgs e)
        {
            EmployeeBAL employeebalobj = new EmployeeBAL();
            DataTable dt = new DataTable();

            dt = employeebalobj.get();
            grid_output.DataSource = dt;
        }


        /// <summary>
        ///This function is called when the delete button is clicked on the form and passes the DTO object to the bussiness layer.
        /// </summary>
        private void bttn_delete_Click(object sender, EventArgs e)
        {
            EmployeeBAL employeebalobj = new EmployeeBAL();
            employeebalobj.delete(add_to_DTOobj());
            MessageBox.Show("deleted sucessfully");

        }

        /// <summary>
        ///This function is called when the update button is clicked on the form and passes the DTO object to the bussiness layer.
        /// </summary>
        private void bttn_update_Click(object sender, EventArgs e)
        {
            EmployeeBAL employeebalobj = new EmployeeBAL();
            employeebalobj.update(add_to_DTOobj());
            MessageBox.Show("updated successfully");
            
        }
        
    }
}
