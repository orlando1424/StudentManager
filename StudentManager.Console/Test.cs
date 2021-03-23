using System;
using System.Collections.Generic;
using StudentManager.BL;
using StudentManager.Console;

namespace StudentManager.Console
{
    public class Test
    {
        static void Main(string[] args)
        {
            School school = new School();
            
            DisplayStudents(school.GetAllStudents());
            school.AddStudent(6, "Joe Smith", new Program() { Id = 100, Name = "Corey's Amazing Course" });
            DisplayStudents(school.GetAllStudents());
        }

        static void DisplayStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                System.Console.WriteLine(student.Name);
            }
        }
    }
}
