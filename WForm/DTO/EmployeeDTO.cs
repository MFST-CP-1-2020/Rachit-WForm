using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// This is a Data Transfer object class that contains the properties that are to be stored in the database Employee.
    /// </summary>
    public class EmployeeDTO
    {   public int eid { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public long phne_number { get; set; }
        public string gender { get; set; }
        public string state { get; set; }
        public string city { get; set; }
    }
}
