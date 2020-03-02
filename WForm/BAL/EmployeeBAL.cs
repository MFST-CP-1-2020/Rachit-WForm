using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using BAL.mapper;
namespace BAL
{

    /// <summary>
    /// This class is present in the bussiness layer of the employee form
    /// </summary>
    public class EmployeeBAL
    {
        /// <summary>
        /// This function passes the object recieved from PAL to DAL by converting the object type.
        /// </summary>
        /// <param name="dtoobj">the object recieved from PAL</param>
        public void addusingDAL(EmployeeDTO dtoobj)
        {
            Employeemapper mapperobj = new Employeemapper();
            

            
            EmployeeDAL dalobj = new EmployeeDAL();
            dalobj.add(mapperobj.to_modelobj(dtoobj));

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
        /// <param name="dtoobj"> This object contains the id of the Employee who's data we wish to delete from the database</param>
        public void delete(EmployeeDTO dtoobj)
        {
            Employeemapper mapperobj = new Employeemapper();
            EmployeeDAL edalobj = new EmployeeDAL();
            edalobj.delete(mapperobj.to_modelobj(dtoobj));
        
        }

        /// <summary>
        /// This function is used to update a particular entry in the database
        /// </summary>
        public void update(EmployeeDTO dtoobj)
        {
            Employeemapper mapperobj = new Employeemapper();
            EmployeeDAL eobj = new EmployeeDAL();
            eobj.update(mapperobj.to_modelobj(dtoobj));


        }   
    }
}
