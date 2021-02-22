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
            Program program3 = new Program() { id = 3, name = "SQL and Databases" };
            Program program4 = new Program() { id = 4, name = ".NET and MVC" };

            // add programs to the Programs List
            Programs.Add(program1);
            Programs.Add(program2);
            Programs.Add(program3);
            Programs.Add(program4);

            // List for Students
            Students = new List<Student>();

            // Current Students
            Student student1 = new Student() { ID = 1, Name = "Todd Bummer", Program=program1};
            Student student2 = new Student() { ID = 2, Name = "John James", Program = program2 };
            Student student3 = new Student() { ID = 3, Name = "Orlando Lopez", Program = program3 };
            Student student4 = new Student() { ID = 4, Name = "Cristiano Ronaldo", Program = program4 };

        }

       /* public School GetStudents()
        {
            foreach (var student in Students)
            {
                return student.ToString();
            }

        } */

    }
}
