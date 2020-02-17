using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WForm.EventAndDelegate
{
    


    public partial class Form2 : Form
    {
        List<user> user_list = new List<user>();
        DataTable state = new DataTable();
        DataTable country = new DataTable();

        public Form2()
        {
            InitializeComponent();
        }
        public void add_to_user()
        {
            user obj = new user();
            obj.fname = firstname_textbox.Text;
            obj.lname = lastname_textbox.Text;
            obj.phne_number = long.Parse(phnenumber_textbox.Text);
            obj.address = address_textbox.Text;
            if (male_radiobutton.Checked)
                obj.gender = male_radiobutton.Text;
            else
                obj.gender = female_radiobutton.Text;
            obj.country = country_combobox.Text;
            obj.state = state_combobox.Text;
            user_list.Add(obj);


          //  var source = new BindingSource();
           // source.DataSource = user_list;
            dataGridView1.DataSource = user_list;
        }
        public void make_country()
        {
            country.Columns.Add("id");
            country.Columns.Add("Country");

            country_combobox.DisplayMember = "Country";
           

            
        }
        public void add_to_country()
        {
            country.Rows.Add("1", "India");
            country.Rows.Add("2", "America");
            country.Rows.Add("3", "England");
            country.Rows.Add("4", "Japan");
            country_combobox.DataSource = country;
        }
        public void bindstate()
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            add_to_user();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            make_country();
            add_to_country();
            make_state();
        }

        public void make_state()
        {
            state.Columns.Add("id");
            state.Columns.Add("state");
            
        }
        public void add_to_state()
        {
            state.Clear();
            
            if(country_combobox.SelectedIndex==0)
            {
                state.Rows.Add(1,"UP");
                state.Rows.Add(2,"MP");
                state.Rows.Add(3,"AP");
            }
            if(country_combobox.SelectedIndex==1)
            {
                state.Rows.Add(1,"texas");
                state.Rows.Add(2,"california");
            }
            if(country_combobox.SelectedIndex==2)
            {
                state.Rows.Add(1,"wales");
                state.Rows.Add(2,"London");
            }
            if(country_combobox.SelectedIndex==3)
            {
                state.Rows.Add(1,"tokoyo");
                state.Rows.Add(2,"hiroshima");
            }
            state_combobox.DisplayMember = "state";
            state_combobox.DataSource = state;
        }
        private void country_combobox_DropDownClosed(object sender, EventArgs e)
        {
           // state.Clear();
            add_to_state();
        }
    }
    public class user
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public long phne_number { get; set; }
         public string address { get; set; }
        public string gender { set; get; }
        public string country { get; set; }
        public string state { get; set; }

    }

}
