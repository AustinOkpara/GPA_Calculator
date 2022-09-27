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
        public static void PrintTableMethod(List<Course> courseList)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;  
            //Console.Clear();
            var table = new ConsoleTable($"Course & Code", $"Course Unit", $"Grade", $"Grade Unit", $"Weight Point", $"Remark");

            foreach (var item in courseList)
            {
                table.AddRow($"{item.courseName}", $"{item.courseUnits}", $"{item.grade}", $"{item.gradeUnit}", $"{item.weightPoint}", $"{item.remark}");
            }
             Console.WriteLine(table);
            Grade_Computer.CalculcateStudentGrade();


           /* Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n|--------------|-----------|------|-----------|------------|------------|\n" +
                              "|COURSE & CODE |COURSE UNIT|GRADE |GRADE UNIT |GRADE POINT |REMARK      |\n" +
                              "|--------------|-----------|------|-----------|------------|------------|");
            foreach (var z in courseList)
            {
                Console.WriteLine($"|{z.courseName}       |{z.courseUnits}          |{z.grade}     |{z.gradeUnit}          |{z.weightPoint}           |{z.remark}  |");
            }
            Console.WriteLine("|--------------|-----------|------|-----------|------------|------------|");*/


        }
    }
}
