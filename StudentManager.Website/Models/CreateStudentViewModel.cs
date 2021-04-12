using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManager.Website.Models
{
    public class CreateStudentViewModel
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int ProgramId { get; set; }
        public List<StudentManager.BL.Program> ExistingPrograms { get; set; }
        public List<StudentManager.BL.Student> ExistingStudents { get; set; }
    }
}
