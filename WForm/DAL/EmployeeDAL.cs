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
        /// This function is uesd to add the values from the entries tot he database
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
        /// <param name="eid"> The id of the EmployeeDAL who's data we wish to delete from the database</param>
        public void delete(int eid)
        {
            var entityobj = new TestDBEntities1();
            var deletequerry = (from a in entityobj.Employees where a.Employeeid == eid select a).Single();
            entityobj.Employees.Remove(deletequerry);
            entityobj.SaveChanges();

        }



        
        /// <summary>
        /// This function is used to update a particular entry in the database
        /// </summary>
        public void update(Employee obj)
        {
            var entityobj = new TestDBEntities1();
            Employee employee = (from d in entityobj.Employees where d.Employeeid==obj.Employeeid select d).Single();
            employee.Firstname = obj.Firstname;
            employee.Lastname = obj.Lastname;
            employee.Gender = obj.Gender;
            employee.Phonenumber = obj.Phonenumber;
            employee.Gender = obj.Gender;
            employee.State = obj.State;
            employee.City = obj.City;
            entityobj.SaveChanges();

        }

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
