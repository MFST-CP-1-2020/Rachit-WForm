﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BAL.mapper
{
    /// <summary>
    /// This is a mapper class that has two function that convert DTO object to model object and vice versa.
    /// </summary>
    class Studentmapper
    {

        /// <summary>
        /// This function converts the DTO object to model object
        /// </summary>
        /// <param name="studentdtoobj">This is the StudentDTo object that contains the values</param>
        /// <returns>A model object that contains the values of the StudentDTO object</returns>
        public Student to_modelobj(StudentDTO studentdtoobj)
        {
            Student obj = new Student();
            obj.City = studentdtoobj.city;
            obj.Gender = studentdtoobj.gender;
            obj.Firstname = studentdtoobj.fname;
            obj.Lastname = studentdtoobj.lname;
            obj.Phonenumber = studentdtoobj.phne_number;
            obj.State = studentdtoobj.state;
            obj.City = studentdtoobj.city;
            obj.Studentid = studentdtoobj.sid;
            return obj;
        }

        /// <summary>
        /// This function converts the model object to DTO object
        /// </summary>
        /// <param name="obj">A student object that contains the values to be passed</param>
        /// <returns>a DTO object that contains the values of the model object</returns>
        public StudentDTO to_dtoobj(Student obj)
        {
            StudentDTO studentdtoobj = new StudentDTO();
            studentdtoobj.city = obj.City;
            studentdtoobj.gender = obj.Gender;
            studentdtoobj.fname = obj.Firstname;
            studentdtoobj.lname = obj.Lastname;
            studentdtoobj.phne_number = obj.Phonenumber;
            studentdtoobj.state = obj.State;
            studentdtoobj.city = obj.City;
            studentdtoobj.sid = obj.Studentid;
            return studentdtoobj;
        }

    }
}
