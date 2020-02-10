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
        DataTable table = new DataTable();
        DataTable dt = new DataTable();
        //DataColumn Fname = new DataColumn("first_name");
        //DataColumn Lname = new DataColumn("Last_name");
        //DataColumn Fthername
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
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");

            DataRow r = dt.NewRow();
            r["Id"] = 1;
            r["Name"] = "one";

            table.Columns.Add("First Name");
            table.Columns.Add("Last Name");
            table.Columns.Add("Father's Name");
            table.Columns.Add("Mother's Name");
            table.Columns.Add("Phone Number");
            table.Columns.Add("Address");
            table.Columns.Add("State");
            table.Columns.Add("Country");
            table.Columns.Add("Gender");
            dt.Rows.Add(r);
            cb1.DataSource = dt;
            cb1.DisplayMember = "Name";
            cb1.ValueMember = "Id";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //table.c.Rows.Add(textBox1.Text);
            DataRow row = table.NewRow();
                        row[0] = textBox1.Text;
            row[1] = textBox2.Text;
            row[2] = textBox3.Text;
            row[3] = textBox4.Text;
            row[4] = textBox5.Text;
            row[5] = textBox6.Text;
            row[6] = textBox8.Text;
            row[7] = textBox9.Text;
            row[8] = textBox7.Text;
            table.Rows.Add(row);
            c.DataSource = table;
            
           
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
    }
}
