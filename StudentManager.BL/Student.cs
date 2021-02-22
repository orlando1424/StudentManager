using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.BL
{
    public class Student
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public Program Program { get; set; }

        public void SetStudent(long id, string name, Program program)
        {
            ID = id;
            Name = name;
            Program = program;
        }

        
        
    }
}
