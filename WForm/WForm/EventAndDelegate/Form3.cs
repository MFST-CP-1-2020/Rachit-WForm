using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace WForm.EventAndDelegate
{
    
    public partial class Form3 : Form
    {
        //Form2 obj = new Form2();
        //int pos = 0;

        public void xml()
        {
           /* user user = new user();
            XmlWriter xmlWriter = XmlWriter.Create("test.xml");
            xmlWriter.WriteStartElement("user");



            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("address", user.address);
            xmlWriter.WriteAttributeString("Country", user.country);
            xmlWriter.WriteAttributeString("State", user.state);
            xmlWriter.WriteAttributeString("phone", user.phne_number.ToString());
            xmlWriter.WriteString(user.fname + user.lname);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
            */
        }
        public Form3()
        {
            InitializeComponent();
            //xml();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void firstname_textbox_TextChanged(object sender, EventArgs e)
        {

        }
        public void add_to_output()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"d:\projects\wformcp\rachit-wform.git\wform\wform\eventanddelegate\xmlfile1.xml");
            dataGridView1.DataSource = ds.Tables;
            
          //  pos = pos + 1;
        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            //user user = new user();
            // obj.add_to_user();
            //xml();
            
            add_to_output();
            //dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.DataSource = ds.Tables;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //obj.make_country();
            //obj.add_to_country();
            //obj.make_state();
        }

        private void country_combobox_DropDownClosed(object sender, EventArgs e)
        {
            //obj.add_to_state();
        }
    }

}
