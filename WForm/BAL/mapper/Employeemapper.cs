using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BAL.mapper
{
    class Employeemapper
    {

        public Employee to_modelobj(EmployeeDTO e)
        {
            Employee obj = new Employee();
            obj.City = e.city;
            obj.Gender = e.gender;
            obj.Firstname = e.fname;
            obj.Lastname = e.lname;
            obj.Phonenumber = e.phne_number;
            obj.State = e.state;
            obj.City = e.city;
            obj.Employeeid = e.eid;
            return obj;
        }
        public EmployeeDTO to_dtoobj(Employee obj)
        {
            EmployeeDTO e = new EmployeeDTO();
            e.city= obj.City;
            e.gender= obj.Gender;
            e.fname= obj.Firstname;
            e.lname= obj.Lastname;
            e.phne_number= obj.Phonenumber;
            e.state= obj.State;
            e.city= obj.City;
            return e;
        }

    }
}
