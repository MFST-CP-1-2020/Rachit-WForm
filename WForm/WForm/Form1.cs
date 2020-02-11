using System;
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
       // Form1 frm;
        DataTable user = new DataTable();
        DataTable dt = new DataTable();
        DataTable state = new DataTable();
        DataTable country = new DataTable();
        //DataColumn Fname = new DataColumn("first_name");
        //DataColumn Lname = new DataColumn("Last_name");
        //DataColumn Fthername

        public void bindcontent()
        {
            bindstate();
            bindcountry();
            makeuser();
            
        }
        public void addrow(int i,string s)
        {
            DataRow r = state.NewRow();
            r["id"] = i;
            r["Name"] = s;
            state.Rows.Add(r);
        }
        public void bindstate()
        {
            state.Columns.Add("id", typeof(int));
            state.Columns.Add("Name", typeof(string));

            /*DataRow r = state.NewRow();
            r["id"] = 1;
            r["Name"] = "UttarPradesh";
            state.Rows.Add(r);
            DataRow r2 = state.NewRow();
            r2["id"] = 2;
            r2["Name"] = "Maharastra";
            state.Rows.Add(r2);
            DataRow r3 = state.NewRow();
            r3["id"] = 3;
            r3["Name"] = "Jammu";
            state.Rows.Add(r3);

            DataRow r4 = state.NewRow();
            r4["id"] = 4;
            r4["Name"] = "Kashmir";

            state.Rows.Add(r4);
            //state.Rows.Add(r);
            */
            addrow(0, "choose");
            addrow(1, "UttarPradesh");
            addrow(2, "Maharastra");
            addrow(3, "Jammu");
            addrow(4, "Kashmir");
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = state;
        }
        public void makeuser()
        {

            user.Columns.Add("First Name");
            user.Columns.Add("Last Name");
            user.Columns.Add("Father's Name");
            user.Columns.Add("Mother's Name");
            user.Columns.Add("Phone Number");
            user.Columns.Add("Address");
            user.Columns.Add("State");
            user.Columns.Add("Country");
            user.Columns.Add("Gender");
            user.Columns.Add("Load");
            //DataGridViewButtonColumn bttn_load = new DataGridViewButtonColumn();
            //c.Columns.Add(bttn_load);

        }
        public void add_to_user()
        { 
            DataRow row = user.NewRow();
            row[0] = textBox1.Text;
            row[1] = textBox2.Text;
            row[2] = textBox3.Text;
            row[3] = textBox4.Text;
            row[4] = textBox5.Text;
            row[5] = textBox6.Text;
            row["State"] = comboBox1.Text;
            row["Country"] = comboBox2.Text;
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
            c.DataSource = user;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            string value = country.Rows[0]["name"].ToString();

            comboBox1.Text = value;
            comboBox2.Text = value;
            DataGridViewButtonColumn bttn_load = new DataGridViewButtonColumn();
            bttn_load.HeaderText = "Load data";
            bttn_load.Name = "bttn_load";
            bttn_load.UseColumnTextForButtonValue = true;
          //  if (c.Columns.Contains(bttn_load.Name = "bttn_load"))
            //{
            //
            //}
            //else
                c.Columns.Add(bttn_load);
            
        }
        public void bindcountry()
        {

            country.Columns.Add("id", typeof(int));
            country.Columns.Add("name", typeof(string));
            country.Rows.Add(0, "choose");
            country.Rows.Add(1, "India");
            country.Rows.Add(2, "America");
            country.Rows.Add(3, "Australia");
            country.Rows.Add(4, "England");
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";
            comboBox2.DataSource = country;
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
            //dt.Columns.Add("Id");
            //dt.Columns.Add("Name");

            //DataRow r = dt.NewRow();
            //r["Id"] = 1;
            //r["Name"] = "one";
           bindcontent();
            
            //dt.Rows.Add(r);
          //  cb1.DataSource = dt;
            //cb1.DisplayMember = "Name";
            //cb1.ValueMember = "Id";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //table.c.Rows.Add(textBox1.Text);
            /* DataRow row = user.NewRow();
             row[0] = textBox1.Text;
             row[1] = textBox2.Text;
             row[2] = textBox3.Text;
             row[3] = textBox4.Text;
             row[4] = textBox5.Text;
             row[5] = textBox6.Text;
             row["State"] = comboBox1.Text;
             row["Country"] = comboBox2.Text;
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
             c.DataSource = user;
             */
            //bindcontent();
            add_to_user();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //table.c.Rows.Add(textBox1.Text);

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
    }
}
