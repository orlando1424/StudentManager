using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManager.BL;
using StudentManager.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManager.Website.Controllers
{
    public class StudentController : Controller
    {
        School school;

        public StudentController()
        {
            school = School.CreateSchool();
        }
        public IActionResult Index()
        {
            return View(school.GetAllStudents());
        }
        public IActionResult create()
        {
            CreateStudentViewModel vm = new CreateStudentViewModel();
            vm.ExistingPrograms = school.GetAllPrograms();
            return View(vm);
        }

        [HttpPost]
        public IActionResult create(CreateStudentViewModel viewModel)
        {
            /*School school = new School();
            int studentId = student.ID;
            string name = student.Name; */
            
            school.AddStudent(viewModel.StudentId, viewModel.Name, school.GetProgramById(viewModel.ProgramId));

            /* if (!valid) {
                viewModel.ExistingPrograms = school.GetAllPrograms().ToList(); 
                return View(viewModel);
               }
             */
                
            return RedirectToAction("Index");
        }

        public IActionResult delete()
        {

            return View(school.GetAllStudents());
        }

        [HttpPost]
        public IActionResult delete(IFormCollection collection)
        {
            school.DeleteStudent(int.Parse(collection["id"]));
            return RedirectToAction("Index");
        }

     
        public IActionResult edit()
        {
            CreateStudentViewModel vm = new CreateStudentViewModel();
            vm.ExistingStudents = school.GetAllStudents();
            vm.ExistingPrograms = school.GetAllPrograms();
            return View(vm);
        }

        [HttpPost]

        public IActionResult edit(CreateStudentViewModel viewModel)
        {
            school.EditStudent(viewModel.StudentId, viewModel.Name, school.GetProgramById(viewModel.ProgramId));

            return RedirectToAction("Index");
        }

    }
}
