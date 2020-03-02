using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;
using BAL.mapper;
using DTO;
namespace BAL
{


    /// <summary>
    /// This is the class that is present in the bussiness layer of the form.This form has the add,update,delete and get methods
    /// </summary>
    public class StudentBAL
    {
       


        /// <summary>
        ///  This function returns a datatable that contains the databse
        /// </summary>
        public DataTable get()
        {
            StudentDAL studentdalobj = new StudentDAL();
            DataTable dt = new DataTable();
            dt = studentdalobj.get();
            return dt;

        }

        /// <summary>
        /// This function is uesd to add the values from the entries tot he database
        /// </summary>
        public void add(StudentDTO dtoobj)
        {
            Studentmapper mapperobj = new Studentmapper();
            StudentDAL studentdalobj = new StudentDAL();
            studentdalobj.add(mapperobj.to_modelobj(dtoobj));

        }


        
        /// <summary>
        /// This function is used to delete a row from the database
        /// </summary>
        /// <param name="dtoobj"> This object conatins the id of the Employee who's data we wish to delete from the database</param>
        public void delete(StudentDTO dtoobj)
        {
            Studentmapper mapperobj = new Studentmapper();
            StudentDAL studentdalobj = new StudentDAL();
            studentdalobj.delete(mapperobj.to_modelobj(dtoobj));

        }
        /// <summary>
        /// This function is used to update a particular entry in the database
        /// </summary>
        public void update(StudentDTO dtoobj)
        {

            Studentmapper mapperobj = new Studentmapper();
            StudentDAL studentdalobj = new StudentDAL();
            studentdalobj.update(mapperobj.to_modelobj(dtoobj));
    
        }
    }
}
