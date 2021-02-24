using System;
using StudentManager.BL;
using StudentManager.Console;

namespace StudentManager.Console
{
    public class Test
    {
        static void Main(string[] args)
        {
            School school = new School();
            school.GetAllStudents();

            school.GetAllPrograms();
        }
    }
}
