using System;
using System.Collections.Generic;

namespace StudentManager.BL
{
    public class School
    {
        public List<Student> Students { get; set; }
        public List<Program> Programs { get; set; }

        // School Constructor 
        public School()
        {

            // List for Programs
            Programs = new List<Program>();

            // Current Programs
            Program program1 = new Program() { id = 1, name = "Quantum Physics" };
            Program program2 = new Program() { id = 2, name = "C# - Intro" };

            // add programs to the Programs List
            Programs.Add(program1);
            Programs.Add(program2);


            // List for Students
            Students = new List<Student>();

            // Current Students
            Student student1 = new Student() { ID = 1, Name = "Todd Bummer", Program=program1};
            Student student2 = new Student() { ID = 2, Name = "John James", Program = program2 };

        }

    }
}
