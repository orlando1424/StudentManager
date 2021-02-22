using System;
using System.Collections.Generic;

namespace StudentManager.BL
{
    public class School
    {
        public List<Student> Students { get; set; }
        public List<Program> Programs { get; set; }
        public School()
        {


            Programs = new List<Program>();
            Program program1 = new Program() { id = 1, name = "Quantum Physics" };
            Programs.Add(program1);


            Students = new List<Student>();
            Student student = new Student() { ID = 1, Name = "Todd Bummer", Program=program1};

        }

    }
}
