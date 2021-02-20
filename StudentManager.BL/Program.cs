using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.BL
{
   public class Program
    {
        private long id { get; set; }
        private string name { get; set; }
        private IEnumerable<Student> students { get; set; }
    }
}
