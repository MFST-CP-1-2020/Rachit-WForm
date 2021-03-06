﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForm
{
    public partial class Form1 : Form
    {
       
       
        int indexRow;                                                               //This stores the index of row through which from which information is loaded back to the input entries.
        DataTable user = new DataTable();                                           //Datatable that contains all the information to be displayed in the grid.
        DataTable state = new DataTable();                                          //Datatable that contains all the country names and id
        DataTable country = new DataTable();
        

        
        //This function binds the content of datatables to the grid



        
        public void bindcontent()
        {
            bindstate();
            bindcountry();
            makeuser();
            
        }

        //This function provides the functionality of update button
        public void update()
        {
            user.Rows[indexRow][0] = firstname_textbox.Text;
            user.Rows[indexRow][1] = lastname_textbox.Text;
            user.Rows[indexRow][2] = fathername_textbox.Text;
            user.Rows[indexRow][3] = mothername_textbox.Text;
            user.Rows[indexRow][4] = phonenumber_textbox.Text;
            user.Rows[indexRow][5] = address_textbox.Text;
            user.Rows[indexRow][6] = state_combobox.Text;
            user.Rows[indexRow][7] = country_combobox.Text;
            bool b = radioButton1.Checked;
            if (b == true)
            {
                user.Rows[indexRow][8] = radioButton1.Text;
            }
            else
                user.Rows[indexRow][8] = radioButton2.Text;

            firstname_textbox.Text = "";
            lastname_textbox.Text = "";
            fathername_textbox.Text = "";
            mothername_textbox.Text = "";
            phonenumber_textbox.Text = "";
            address_textbox.Text = "";

            string value = country.Rows[0]["name"].ToString();

            state_combobox.Text = value;
            country_combobox.Text = value;
            update_button.Enabled = false;          //This disables the button
            state.Clear();
        }


        public void bindstate()
        {
            state.Columns.Add("id", typeof(int));           //id is the Valuemember
            state.Columns.Add("Name", typeof(string));         //name is the displaymember
            state.Columns.Add("Foriegn_id", typeof(int));
        }
        public void add_to_state()
        {
            state.Clear();
           // state.Rows.Add(0, "choose a state", 0);
            
            
            if (country_combobox.SelectedIndex==1)
            {
                //state.Rows.Add(0, "choose",0);
                state.Rows.Add(1, "UttarPradesh", 1);
                state.Rows.Add(2, "Maharastra", 1);
                state.Rows.Add(3, "Jammu", 1);
                state.Rows.Add(4, "Kashmir", 1);
            }
            else if (country_combobox.SelectedIndex==2)
            {
                state.Rows.Add(5, "new york", 2);
                state.Rows.Add(6, "texas", 2);
                state.Rows.Add(7, "california", 2);
                state.Rows.Add(8, "florida", 2);
            }
            else if (country_combobox.SelectedIndex == 3)
            {
                state.Rows.Add(9, "tokoyo", 3);
                state.Rows.Add(10, "chubu", 3);
                state.Rows.Add(11, "shikoku", 3);
            }
            else
            {
                state.Rows.Add(12, "wales", 4);
                state.Rows.Add(13, "scotland", 4);
                state.Rows.Add(14, "london", 4);
            }
            state_combobox.DisplayMember = "name";
            state_combobox.ValueMember = "id";
            state_combobox.ValueMember = "Foriegn_id";
            state_combobox.DataSource = state;
        }

        //This function adds the columns to the user datatable 
        public void makeuser()
        {

            user.Columns.Add("First Name",typeof(string));
            user.Columns.Add("Last Name",typeof(string));
            user.Columns.Add("Father's Name",typeof(string));
            user.Columns.Add("Mother's Name",typeof(string));
            user.Columns.Add("Phone Number",typeof(long));
            user.Columns.Add("Address");
            user.Columns.Add("State");
            user.Columns.Add("Country");
            user.Columns.Add("Gender");

        }


        //This function is used to add rows to the user datatable
        public void add_to_user()
        { 
            DataRow row = user.NewRow();
            row[0] = firstname_textbox.Text;
            row[1] = lastname_textbox.Text;
            row[2] = fathername_textbox.Text;
            row[3] = mothername_textbox.Text;
            row[4] = phonenumber_textbox.Text;
            row[5] = address_textbox.Text;
            row["State"] = state_combobox.Text;
            row["Country"] = country_combobox.Text;
            string gender;
            bool ischecked = radioButton1.Checked;
            if (ischecked)
            {
                gender = radioButton1.Text;
            }
            else
                gender = radioButton2.Text;
            row[8] = gender;
            user.Rows.Add(row);
            output_grid.DataSource = user;

            firstname_textbox.Text = "";
            lastname_textbox.Text = "";
            fathername_textbox.Text = "";
            mothername_textbox.Text = "";
            phonenumber_textbox.Text = "";
            address_textbox.Text = "";

            string value = country.Rows[0]["name"].ToString();
            
            state_combobox.Text = value;
            country_combobox.Text = value;

            //The following logic is used to add the button in the column of the user datatable

            DataGridViewButtonColumn bttn_load = new DataGridViewButtonColumn();
            bttn_load.HeaderText = "Load data";
            bttn_load.Text = "Load";
            bttn_load.Name = "bttn_load";
            bttn_load.UseColumnTextForButtonValue = true;
           if (output_grid.Columns.Contains(bttn_load.Name = "bttn_load"))
            {
            
            }
            else
                output_grid.Columns.Add(bttn_load);
            DataGridViewButtonColumn bttn_delete = new DataGridViewButtonColumn();
            bttn_delete.HeaderText = "delete data";
            bttn_delete.Text = "delete";
            bttn_delete.Name = "bttn_delete";
            bttn_delete.UseColumnTextForButtonValue = true;
            if (output_grid.Columns.Contains(bttn_delete.Name = "bttn_delete"))
            {

            }
            else
                output_grid.Columns.Add(bttn_delete);
        }


        //This function is used to add columns and rows in the country datatable
        public void bindcountry()
        {

            country.Columns.Add("id", typeof(int));
            country.Columns.Add("name", typeof(string));
            country.Rows.Add(0, "choose");
            country.Rows.Add(1, "India");
            country.Rows.Add(2, "America");
            country.Rows.Add(3, "japan");
            country.Rows.Add(4, "England");
            country_combobox.DisplayMember = "name";
            country_combobox.ValueMember = "id";
            country_combobox.DataSource = country;
            }


        public Form1()
        {

            InitializeComponent();

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           bindcontent();
            update_button.Enabled = false;                      //This results in a disabled button
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        //This function discribes the functionality of the submit button in the registration form
        private void button1_Click(object sender, EventArgs e)
        {
            
            add_to_user();
            state.Clear();

        }


        //This function discribes the functionality of the load button that is present on the output grid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexcolmn = e.ColumnIndex;
            indexRow = e.RowIndex;
            if (indexcolmn == 9)
            {
                DataGridViewRow row = output_grid.Rows[indexRow];
                firstname_textbox.Text = row.Cells[0].Value.ToString();
                lastname_textbox.Text = row.Cells[1].Value.ToString();
                fathername_textbox.Text = row.Cells[2].Value.ToString();
                mothername_textbox.Text = row.Cells[3].Value.ToString();
                phonenumber_textbox.Text = row.Cells[4].Value.ToString();
                address_textbox.Text = row.Cells[5].Value.ToString();
                country_combobox.Text = row.Cells[7].Value.ToString();
                string gender = row.Cells[8].Value.ToString();
                if (gender.Equals(radioButton1.Text))
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;

                update_button.Enabled = true;
                add_to_state();
                state_combobox.Text = row.Cells[6].Value.ToString();
            }
            else
            {
                output_grid.Rows.RemoveAt(indexRow);

            }
        }



        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        //This funtion describes the functionality of the update button present on the registration form
        private void button_update_Click(object sender, EventArgs e)
        {
            update();
        }

        private void state_combobox_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void country_combobox_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void country_combobox_DropDownClosed(object sender, EventArgs e)
        {
            add_to_state();
        }

        private void country_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // add_to_state();
        }
    }
}
