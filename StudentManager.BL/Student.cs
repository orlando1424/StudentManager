using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.BL
{
    public class Student
    {
        private long ID { get; set; }
        private string Name { get; set; }
        private Program Program { get; set; }

        public void SetStudent(long id, string name, Program program)
        {
            ID = id;
            Name = name;
            Program = program;
        }

        
        
    }
}
