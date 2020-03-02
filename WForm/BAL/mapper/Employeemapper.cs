using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BAL.mapper
{

    /// <summary>
    /// This is a mapper class that has two function that convert DTO object to model object and vice versa.
    /// </summary>
    class Employeemapper
    {
        /// <summary>
        /// This function converts the DTO object to model object
        /// </summary>
        /// <param name="employeetoobj">This is the EmployeeDTo object that contains the values</param>
        /// <returns>A model object that contains the values of the EmployeeDTO object</returns>

        public Employee to_modelobj(EmployeeDTO employeeobj)
        {
            Employee obj = new Employee();
            obj.City = employeeobj.city;
            obj.Gender = employeeobj.gender;
            obj.Firstname = employeeobj.fname;
            obj.Lastname = employeeobj.lname;
            obj.Phonenumber = employeeobj.phne_number;
            obj.State = employeeobj.state;
            obj.City = employeeobj.city;
            obj.Employeeid = employeeobj.eid;
            return obj;
        }

        /// <summary>
        /// This function converts the model object to DTO object
        /// </summary>
        /// <param name="obj">An employee object that contains the values to be passed</param>
        /// <returns>a DTO object that contains the values of the model object</returns>param>
        
        public EmployeeDTO to_dtoobj(Employee obj)
        {
            EmployeeDTO employeedtoobj = new EmployeeDTO();
            employeedtoobj.city= obj.City;
            employeedtoobj.gender= obj.Gender;
            employeedtoobj.fname= obj.Firstname;
            employeedtoobj.lname= obj.Lastname;
            employeedtoobj.phne_number= obj.Phonenumber;
            employeedtoobj.state= obj.State;
            employeedtoobj.city= obj.City;
            return employeedtoobj;
        }

    }
}
