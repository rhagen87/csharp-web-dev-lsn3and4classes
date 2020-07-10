using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {

        public string name { get; set; }
        public int credits { get; set; }

        public List<string> students = new List<string>();
    }
}
