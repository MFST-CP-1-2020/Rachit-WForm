using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using System.Data.SqlClient;
using DTO;
namespace DAL
{

    /// <summary>
    /// This class is present in the data layer of the form and interacts with the database directly.
    /// </summary>
    public class EmployeeDAL
    {
     
        /// <summary>
        ///  This function returns a datatable that contains the databse
        /// </summary>
        public DataTable get()
        {

            var entityobj = new TestDBEntities1();       
            DataTable t = new DataTable();
            t = addcolm();
            var row = (from d in entityobj.Employees select d);
            foreach(var rowobj in row)
            {
                DataRow datarow = t.NewRow();
                datarow["Employeeid"] = rowobj.Employeeid;
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
        public void add(Employee dtoobj)
        {

            var v = new TestDBEntities1();
            v.Employees.Add(dtoobj);
            v.SaveChanges();
        
        }

        /// <summary>
        /// This function is used to delete a row from the database
        /// </summary>
        public void delete(Employee modelobj)
        {
            var context = new TestDBEntities1();

            context.Entry(modelobj).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();

        }

        /// <summary>
        /// This function is used to update a particular entry in the database
        /// </summary>
        public void update(Employee modelobj)
        {
            var context = new TestDBEntities1();
            context.Entry(modelobj).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

        }

        /// <summary>
        /// This function adds the columns to the datatable that will be returned to the bussiness layer.
        /// </summary>
        public DataTable addcolm()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Employeeid");
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
