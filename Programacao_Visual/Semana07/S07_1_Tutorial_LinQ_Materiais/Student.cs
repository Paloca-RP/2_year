using System;
using System.Collections.Generic;
using System.Text;

namespace TP06_TutorialLinQ
{
    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return StudentName + "\t" + StudentID + "\t" + Age;
        }
    }
}
