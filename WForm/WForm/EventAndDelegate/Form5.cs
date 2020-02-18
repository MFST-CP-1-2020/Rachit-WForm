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
       public Employee add_to_obj()
        {
            
            
                Employee obj = new Employee();
                obj.fname = firstname_textbox.Text;
                obj.lname = lastname_textbox.Text;
                obj.eid = int.Parse(employeeid_text.Text);
                obj.state = state_textbox.Text;
                obj.city = city_textbox.Text;
            try
            {
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

        private void submit_button_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj=add_to_obj();
            obj.add();
            MessageBox.Show("Added successfully");
        }

        private void view_button_Click(object sender, EventArgs e)
        {
            Employee ee = new Employee();
            DataTable dt = new DataTable();
            dt = ee.get();
            outputgrid.DataSource = dt;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            Employee ee = new Employee();
            ee.delete(int.Parse(employeeid_text.Text));
            MessageBox.Show("deleted sucessfully");
        }

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

        public DataTable get()
        {

            SqlConnection conn;
            SqlCommand comm;

            string connstring = @"database=TestDB;server=RACHIT-PC\SQLEXPRESS;User Id=sa;Password=mindfire@1";
            conn = new SqlConnection(connstring);
            conn.Open();

            comm = new SqlCommand();
            comm.Connection = conn;
            SqlDataAdapter a = new SqlDataAdapter("select * from Employee",conn);
            DataTable t = new DataTable();
            a.Fill(t);
            return t;
            

        }

        public void add()
        {
             //MessageBox.Show("function called");
            SqlConnection conn;
            SqlCommand comm;

            string connstring = @"database=TestDB;server=RACHIT-PC\SQLEXPRESS;User Id=sa;Password=mindfire@1";
            conn = new SqlConnection(connstring);
            conn.Open();

            comm = new SqlCommand();
            comm.Connection = conn;

            // SqlParameter proll = new SqlParameter();
            //proll.ParameterName = "@eroll";
            //proll.SqlDbType = SqlDbType.Int;
            //proll.Direction = ParameterDirection.Input;
            string cmd = $"insert into Employee values('{gender}','{city}','{state}',{phne_number},'{lname}','{fname}',{eid});";
            //MessageBox.Show(fname);
            comm.CommandText = cmd;
            comm.ExecuteNonQuery();
            //MessageBox.Show("function exited");


        }
        public void delete(int eid)
        {
            SqlConnection conn;
            SqlCommand comm;
            string connstring = @"database=TestDB;server=RACHIT-PC\SQLEXPRESS;User Id=sa;Password=mindfire@1";
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand();
            comm.Connection = conn;
            string query = $"delete from Employee where Employeeid={eid}";
            comm.CommandText = query;
            comm.ExecuteNonQuery();




        }
        public void update()
        {
            SqlConnection conn;
            SqlCommand comm;

            string connstring = @"database=TestDB;server=RACHIT-PC\SQLEXPRESS;User Id=sa;Password=mindfire@1";
            conn = new SqlConnection(connstring);
            conn.Open();

            comm = new SqlCommand();
            comm.Connection = conn;

            string query = $"update Employee set gender='{gender}',city='{city}',State='{state}',Phonenumber={phne_number},lastname='{lname}',firstname='{fname}' where employeeid={eid}";
            comm.CommandText = query;
            comm.ExecuteNonQuery();
        }
    }
}
