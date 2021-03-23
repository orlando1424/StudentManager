using System;
using System.Collections.Generic;
using System.Linq;

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
            Program program1 = new Program() { Id = 1, Name = "Quantum Physics" };
            Program program2 = new Program() { Id = 2, Name = "C# - Intro" };
            Program program3 = new Program() { Id = 3, Name = "SQL and Databases" };
            Program program4 = new Program() { Id = 4, Name = ".NET Development and MVC" };
           

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

            // add students to Student List
            Students.Add(student1);
            Students.Add(student2);
            Students.Add(student3);
            Students.Add(student4);

        }

        public List<Student> GetAllStudents() => Students;

        public List<Program> GetAllPrograms() => Programs;

        public void AddStudent(int id, string name, Program program)
        {
            Students.Add(new Student() { ID = id, Name = name, Program = program });
        }

        public Student GetStudentById(int id)
        {
            return Students.SingleOrDefault(s => s.ID == id);
        }

        public void DeleteStudent(int id)
        {
            Student delStudent = GetStudentById(id);
            Students.Remove(delStudent);
        }

    }
}
