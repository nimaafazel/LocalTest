using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalGit.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string name { get; set; }
        public DateTime dob { get; set; }
        public int grade { get; set; }
    }
}