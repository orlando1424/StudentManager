using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.BL
{
    public class Student
    {
        public long id { get; set; }
        public string name { get; set; }
        public Program program { get; set; }
    }
}
