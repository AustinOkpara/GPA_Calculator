using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace GPA_Calculator
{
    internal class PrintTable
    {
        public static void TableGenerater(List<Course> courseList)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;  
            //Console.Clear();
            var table = new ConsoleTable($"Course & Code", $"Course Unit", $"Grade", $"Grade Unit", $"Weight Point", $"Remark");

            foreach (var j in courseList)
            {
                table.AddRow($"{j.courseName}", $"{j.courseUnits}", $"{j.grade}", $"{j.gradeUnit}", $"{j.weightPoint}", $"{j.remark}");
            }
             Console.WriteLine(table);
            Grade_Computer.ComputeStudentGrade();
             

 


        }
    }
}
