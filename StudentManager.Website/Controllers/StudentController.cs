using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManager.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManager.Website.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            School school = new School();
            return View(school.GetAllStudents());
        }

        
    }
}
