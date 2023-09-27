using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvStatics
{
   public class Program
    {
        static void Main(string[] args) 
        {
            List<StudentModel> studentsList = new List<StudentModel>();
            {
                new StudentModel()
                {
                    studentName = "Student A",
                    prelim = 78.88,
                    midterm = 85.00,
                    finals = 100.00
                };

                new StudentModel()
                {
                    studentName = "Student B",
                    prelim = 56.76,
                    midterm = 98.00,
                    finals = 100.00
                };

             
            }



            GetMean.DisplayPrelimMean(studentsList);


            //foreach (var stud in studentsList)
            //{
            //    Console.WriteLine($"{stud.studentName}: Prelim = {stud.prelim},    Midterm = {stud.midterm}, Finals = {stud.finals}");
            //}

        }
   }
}
