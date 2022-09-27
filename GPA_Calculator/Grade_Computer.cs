using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System .Text.RegularExpressions;

namespace GPA_Calculator
{
    internal class Grade_Computer
    {
     
            public static void CalculcateStudentGrade()
            {
               // Console.Clear();
                Console.WriteLine("How many courses do you offer?");
                int totalCourses = int.Parse(Console.ReadLine());



                string courseName;
                int courseUnits;
                double score;
                string remark;
                string grade;
                int gradeUnit;
                int weightPoint;
                double totalWeightPoint = 0;
                int totalCourseUnit = 0;
                double gpa;



                List<Course> courseList = new List<Course>();



                for (int i = 0; i < totalCourses; i++)

                {    
                    Go_Here:
                    Console.WriteLine("Please enter your course name and code");
                    courseName = Console.ReadLine();
                    var pattern = new Regex(@"(^[A-Za-z]{3}[0-9]{3}$)");
                    if(!pattern.IsMatch(courseName))
                    {
                      Console.Clear();
                      
                      Console.WriteLine("\n****************************************************************************");
                      Console.WriteLine("Sorry that was a wrong input, enter input in this format 'PHY 101'");
                      goto Go_Here;

                    }


            case1:
                Console.WriteLine("\nPlease enter your courseUnits");
                while (!int.TryParse(Console.ReadLine(), out courseUnits))
                {
                    Console.WriteLine("Wrong Input!, Enter integers only");
                }
                if (courseUnits <= 0)
                {
                    Console.WriteLine("Please Enter a valid course unit");
                    goto case1;
                }
            case2:
                    Console.WriteLine("\nPlease enter your score");
                    while (!double.TryParse(Console.ReadLine(), out score))
                {
                    Console.WriteLine("Wrong Input, Please enter correct values");
                }
                    
                
                    if (score >100 || score < 0)

                    {
                        Console.WriteLine("Please enter a valid input within 1 - 6");
                    goto case2;
                    }


                    if (score > 100 || score < 0)
                    {
                    //Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Please enter a score between 1 - 100");
                    Console.ForegroundColor = ConsoleColor.Red;
                    goto case2;
                    }



                    else if (score >= 70 && score <= 100)
                    {
                        remark = "Excellent";
                        grade = "A";
                        gradeUnit = 5;
                    }
                    else if (score >= 60 && score <= 69)
                    {
                        remark = "Very Good";
                        grade = "B";
                        gradeUnit = 4;
                    }
                    else if (score >= 50 && score <= 59)
                    {
                        remark = "Good     ";
                        grade = "C";
                        gradeUnit = 3;
                    }
                    else if (score >= 45 && score <= 49)
                    {
                        remark = "Fair     ";
                        grade = "D";
                        gradeUnit = 2;
                    }
                    else if (score >= 40 && score <= 44)
                    {
                        remark = "Pass     ";
                        grade = "E";
                        gradeUnit = 1;
                    }
                    else
                    {
                        remark = "Fail";
                        grade = "F";
                         gradeUnit = 0;
                    }



                    Console.WriteLine($"\nYour grade for this course is {grade}");
                    Console.WriteLine(remark + "\n");
                    weightPoint = courseUnits * gradeUnit;



                    totalWeightPoint += weightPoint;
                    totalCourseUnit += courseUnits;



                    Course courseConstructor = new Course(courseName, courseUnits, score, remark, grade, gradeUnit, weightPoint);
                    courseList.Add(courseConstructor);
                }
                gpa = totalWeightPoint / totalCourseUnit;
                //Console.WriteLine(totalWeightPoint);
                //Console.WriteLine(totalCourseUnit);
                //Console.WriteLine(Math.Round(gpa, 2));

                foreach (var item in courseList)
                {
                    Console.WriteLine(item.courseName);
                }



                PrintTable.PrintTableMethod(courseList);

                Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Your Total weight point is : {totalWeightPoint}");
            Console.WriteLine($"Your Toal course units offerd is : {totalCourseUnit}");
            Console.WriteLine($"Your final gpa is :{ Math.Round(gpa, 2)}");

            Console.WriteLine("\nBye for now!\n**************************************************************************************");
                Console.ReadLine();
            }
        
    }
}