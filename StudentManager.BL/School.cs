using System;
using System.Collections.Generic;

namespace StudentManager.BL
{
    public class School
    {
        private IEnumerable<Student> students { get; set; }
        private IEnumerable<Program> programs { get; set; }

        public School(Student student, Program program)
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(student);

            List<Program> programList = new List<Program>();
            programList.Add(program);

        }

    }
}
