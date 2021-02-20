using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.BL
{
   public class Program
    {
        public long id { get; set; }
        public string name { get; set; }
        public IEnumerable<Student> students { get; set; }
    }
}
