using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BAL.mapper
{
    class Studentmapper
    {
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
