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
    /// This class contains all the functions to perform the basic operations such as add,update,delte and add to the database
    /// </summary>
    public partial class Studentregistrationforrm : Form
    {
        public Studentregistrationforrm()
        {
            InitializeComponent();
        }
        
         
        /// <summary>
        ///This function returns an StudentDTO object that contains the values for the properties of the object 
        /// </summary>
        public StudentDTO add_to_DTOobj()
        {
            StudentDTO studentdtoobj = new StudentDTO();
            studentdtoobj.fname = txt_Firstname.Text;
            studentdtoobj.lname = txt_Lastname.Text;
            studentdtoobj.state = txt_State.Text;
            studentdtoobj.city = txt_City.Text;
            try
            {
                studentdtoobj.sid = int.Parse(txt_Studentid.Text);

                studentdtoobj.phne_number = long.Parse(txt_Phonenumber.Text);
            }
            catch (Exception)
            {
            }
            if (radiobttn_Male.Checked)
                studentdtoobj.gender = radiobttn_Male.Text;
            else
                studentdtoobj.gender = radiobttn_Female.Text;
            return studentdtoobj;
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
            txt_Studentid.Clear();
            radiobttn_Male.Checked = false;
            radiobttn_Female.Checked = false;
        }
       
       /// <summary>
       /// This function implements the view or get feature of the form
       /// </summary>
        private void bttn_view_Click(object sender, EventArgs e)
        {
            StudentBAL studentbalobj = new StudentBAL();
            DataTable dt = new DataTable();
            dt = studentbalobj.get();
            grid_output.DataSource = dt;

        }

        /// <summary>
        /// This function implements the delete feature of the form
        /// </summary>
        private void bttn_delete_Click(object sender, EventArgs e)
        {
            StudentBAL studentbalobj = new StudentBAL();
            studentbalobj.delete(add_to_DTOobj());


            MessageBox.Show("deleted sucessfully");
            clearentries();

        }

        /// <summary>
        ///This function implements the update feature of the form 
        /// </summary>
        private void bttn_update_Click(object sender, EventArgs e)
        {
            StudentBAL studentbalobj = new StudentBAL();
            studentbalobj.update(add_to_DTOobj());
           

            MessageBox.Show("updated successfully");
            clearentries();

        }

        /// <summary>
        ///This function implements the add feature of the form 
        /// </summary>
        private void bttn_submit_Click(object sender, EventArgs e)
        {
            StudentBAL studentdtoobj = new StudentBAL();
            studentdtoobj.add(add_to_DTOobj());


            MessageBox.Show("Added successfully");
            clearentries();
        
        }
    }
}

