using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManager.BL
{
    public class School
    {
        /*Singleton*/
        public static School school;

        // check if school is already instantiated this constructor also creates a new "school"
        public static School CreateSchool()
        {
            if (school == null)
                school = new School();
            return school;
        }
        private List<Student> Students;
        private List<Program> Programs;

        // School Constructor 
        private School()
        {

            // List for Programs
            Programs = new List<Program>();

            // Current Programs
            Program program1 = new Program() { Id = 1, Name = "Quantum Physics" };
            Program program2 = new Program() { Id = 2, Name = "C# - Intro" };
            Program program3 = new Program() { Id = 3, Name = "SQL and Databases" };
            Program program4 = new Program() { Id = 4, Name = ".NET Development and MVC" };
            Program program5 = new Program() { Id = 4, Name = "Javascript Basics" };


            // add programs to the Programs List
            Programs.Add(program1);
            Programs.Add(program2);
            Programs.Add(program3);
            Programs.Add(program4);
            Programs.Add(program5);

            // List for Students
            Students = new List<Student>();

            // Current Students
            Student student1 = new Student() { ID = 1, Name = "Todd Bummer", Program=program1};
            Student student2 = new Student() { ID = 2, Name = "John James", Program = program2 };
            Student student3 = new Student() { ID = 3, Name = "Orlando Lopez", Program = program3 };
            Student student4 = new Student() { ID = 4, Name = "Cristiano Ronaldo", Program = program4 };
            //Student student5 = new Student() { ID = 5, Name = "Johnny Test", Program = program5 };

            // add students to Student List
            Students.Add(student1);
            Students.Add(student2);
            Students.Add(student3);
            Students.Add(student4);
            //Students.Add(student5);

        }

        // method to get all students
        public List<Student> GetAllStudents() => Students;
        // method to get all programs
        public List<Program> GetAllPrograms() => Programs;
        //method to get program by ID
        public Program GetProgramById(int id) => Programs.FirstOrDefault(p => p.Id == id);

        public void AddStudent(int id, string name, Program program)
        {
            if (GetStudentById(id) == null)
                Students.Add(new Student() { ID = id, Name = name, Program = program });
            else
                throw new Exception("Student ID already exists");
        }

        public Student GetStudentById(int id)
        {
            return Students.FirstOrDefault(s => s.ID == id);
        }

        public void DeleteStudent(int id)
        {
            Student delStudent = GetStudentById(id);
            Students.Remove(delStudent);
        }

        public void EditStudent(int id, string name, Program program)
        {
            Student editStudent = GetStudentById(id);
            Students.Find(editStudent => editStudent.Name == name);
            Students.Find(editStudent => editStudent.Program == program);
        }

    }
}
