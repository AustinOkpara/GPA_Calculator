using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************HELLO, WELCOME TO YOUR GPA CALCULATOR PORTAL****************************");
            Console.WriteLine("\n");
            string studentName;
            Console.WriteLine("**************************************************************************************************");

            Console.WriteLine("Please input your name");
            studentName = Console.ReadLine().ToUpper();
            Console.WriteLine($"Welcome {studentName}!");

            Console.WriteLine("***************************************************************************************************");

            Grade_Computer.ComputeStudentGrade();




        }
    }
}