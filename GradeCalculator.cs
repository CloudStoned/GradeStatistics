using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvStatics
{
    public  class GradeCalculator
    {
        public static void DisplayGrade(List<StudentModel> studentList)
        {
            foreach (StudentModel student in studentList)
            {
                switch (student.studentName)
                {
                    case "Student A":
                        Console.WriteLine("Student A");
                        Console.WriteLine($"Prelim : {Math.Floor(student.prelim)}");
                        Console.WriteLine($"Midterm: {Math.Floor(student.midterm)}");
                        Console.WriteLine($"Finals : {Math.Floor(student.finals)}");
                        break;

                    case "Student B":
                        Console.WriteLine();
                        Console.WriteLine("Student B");
                        Console.WriteLine($"Prelim : {Math.Floor(student.prelim)}");
                        Console.WriteLine($"Midterm: {Math.Floor(student.midterm)}");
                        Console.WriteLine($"Finals : {Math.Floor(student.finals)}");
                        break;

                    case "Student C":
                        Console.WriteLine();
                        Console.WriteLine("Student C");
                        Console.WriteLine($"Prelim : {Math.Floor(student.prelim)}");
                        Console.WriteLine($"Midterm: {Math.Floor(student.midterm)}");
                        Console.WriteLine($"Finals : {Math.Floor(student.finals)}");
                        break;

                    case "Student D":
                        Console.WriteLine();
                        Console.WriteLine("Student D");
                        Console.WriteLine($"Prelim : {Math.Floor(student.prelim)}");
                        Console.WriteLine($"Midterm: {Math.Floor(student.midterm)}");
                        Console.WriteLine($"Finals : {Math.Floor(student.finals)}");
                        break;

                    case "Student E":
                        Console.WriteLine();
                        Console.WriteLine("Student E");
                        Console.WriteLine($"Prelim : {Math.Floor(student.prelim)}");
                        Console.WriteLine($"Midterm: {Math.Floor(student.midterm)}");
                        Console.WriteLine($"Finals : {Math.Floor(student.finals)}");
                        break;

                    case "Student F":
                        Console.WriteLine();
                        Console.WriteLine("Student F");
                        Console.WriteLine($"Prelim : {Math.Floor(student.prelim)}");
                        Console.WriteLine($"Midterm: {Math.Floor(student.midterm)}");
                        Console.WriteLine($"Finals : {Math.Floor(student.finals)}");
                        break;

                    default:
                        Console.WriteLine("Unknown student");
                        break;
                }
            }
        }
    }
}

