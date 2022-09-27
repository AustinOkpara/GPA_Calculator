using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator
{
    internal class Course
    {
        public string courseName { get; set; }
        public int courseUnits { get; set; }
        public double score { get; set; }
        public string remark { get; set; }
        public string grade { get; set; }
        public int gradeUnit { get; set; }
        public int weightPoint { get; set; }




        public Course(string courseName, int courseUnits, double score,string remark, string grade, int gradeUnit, int weightPoint)
        {
            this.courseName = courseName;
            this.courseUnits = courseUnits;
            this.score = score;
            this.remark = remark;
            this.grade = grade;
            this.gradeUnit = gradeUnit;
            this.weightPoint = weightPoint;
        }
    }
}
