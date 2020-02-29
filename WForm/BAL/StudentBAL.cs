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
        /// <param name="eid"> The id of the Employee who's data we wish to delete from the database</param>
        public void delete(int eid)
        {

            StudentDAL studentdalobj = new StudentDAL();
            studentdalobj.delete(eid);

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
