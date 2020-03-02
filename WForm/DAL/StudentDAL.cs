using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{

    /// <summary>
    /// This class is present in the Data layer of the form and interacts with the database to add,update,delate and get or view the entries of the database
    /// </summary>
    public class StudentDAL
    {

        /// <summary>
        ///  This function returns a datatable that contains the databse
        /// </summary>
        public DataTable get()
        {


            var entityobj = new TestDBEntities1();


            DataTable t = new DataTable();
            t = addcolm();
            var row = (from d in entityobj.Students select d);
            foreach (var rowobj in row)
            {
                DataRow datarow = t.NewRow();
                datarow["Studentid"] = rowobj.Studentid;
                datarow["Firstname"] = rowobj.Firstname;
                datarow["Lastname"] = rowobj.Lastname;
                datarow["Phonenumber"] = rowobj.Phonenumber;
                datarow["Gender"] = rowobj.Gender;
                datarow["City"] = rowobj.City;
                datarow["State"] = rowobj.State;
                t.Rows.Add(datarow);
            }
            return t;
        }

        /// <summary>
        /// This function is uesd to add the values from the entries to the database
        /// </summary>
        public void add(Student studentobj)
        {
            var context = new TestDBEntities1();
            context.Students.Add(studentobj);
            context.SaveChanges();
            
        }

        /// <summary>
        /// This function is used to delete a row from the database
        /// </summary>
        /// <param name="eid"> The id of the Employee who's data we wish to delete from the database</param>
        public void delete(Student modelobj)
        {
            var context = new TestDBEntities1();
      
            context.Entry(modelobj).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

        /// <summary>
        /// This function is used to update a particular entry in the database
        /// </summary>
        public void update(Student studentobj)
        {

            var context = new TestDBEntities1();
            context.Entry(studentobj).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        
        /// <summary>
        /// This function is used to add coloumns to the datatable that will returned to the bussiness layer
        /// </summary>
        public DataTable addcolm()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Studentid");
            dt.Columns.Add("Firstname");
            dt.Columns.Add("Lastname");
            dt.Columns.Add("Phonenumber");
            dt.Columns.Add("Gender");
            dt.Columns.Add("State");
            dt.Columns.Add("City");
            return dt;
        }


    }

}
