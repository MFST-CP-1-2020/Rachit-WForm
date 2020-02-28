using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BAL
{
    public class EmployeeBAL
    {
        

    


        public void addusingDAL(Employee obj)
        {
            EmployeeDAL dalobj = new EmployeeDAL();
            dalobj.add(obj);

        }
        /// <summary>
        ///  This function returns a datatable that contains the databse
        /// </summary>
        public DataTable get()
        {

            EmployeeDAL eobj=new EmployeeDAL();
            
            
            DataTable t = new DataTable();
            t = eobj.get();
             return t;
            
        }

        
        /// <summary>
        /// This function is used to delete a row from the database
        /// </summary>
        /// <param name="eid"> The id of the Employee who's data we wish to delete from the database</param>
        public void delete(int eid)
        {
            EmployeeDAL edalobj = new EmployeeDAL();
            edalobj.delete(eid);
            //Addparameterfordelete(eid);
            //SqlHelperobj.ExecuteNonquery("deletefrom");

        }
        /// <summary>
        /// This function is used to update a particular entry in the database
        /// </summary>
        public void update(Employee dtoobj)
        {

            EmployeeDAL eobj = new EmployeeDAL();
            eobj.update(dtoobj);
            //Addparameterforupdate(dtoobj);
            //SqlHelperobj.ExecuteNonquery("update");
        }
        
    }


  
}
