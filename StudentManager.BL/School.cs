using System;
using System.Collections.Generic;

namespace StudentManager.BL
{
    public class School
    {
        public IEnumerable<Student> students { get; set; }
        public IEnumerable<Program> programs { get; set; }

        public School(Student student, Program program)
        {
          

        }

    }
}
