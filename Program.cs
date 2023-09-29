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

            
            StudentModel studentA = new StudentModel();
            studentA.studentName = "Student A";
            studentA.prelim = 78.88;
            studentA.midterm = 85.00;
            studentA.finals = 100.00;
            studentsList.Add(studentA);

            StudentModel studentB = new StudentModel();
            studentB.studentName = "Student B";
            studentB.prelim = 56.76;
            studentB.midterm = 98.00;
            studentB.finals = 100.00;
            studentsList.Add(studentB);

            
            StudentModel studentC = new StudentModel();
            studentC.studentName = "Student C";
            studentC.prelim = 98.00;
            studentC.midterm = 87.92;
            studentC.finals = 99.00;
            studentsList.Add(studentC);

            StudentModel studentD = new StudentModel();
            studentD.studentName = "Student D";
            studentD.prelim = 87.98;
            studentD.midterm = 85.00;
            studentD.finals = 98.00;
            studentsList.Add(studentD);

            StudentModel studentE = new StudentModel();
            studentE.studentName = "Student E";
            studentE.prelim = 89.00;
            studentE.midterm = 90.15;
            studentE.finals = 97.00;
            studentsList.Add(studentE);

            StudentModel studentF = new StudentModel();
            studentF.studentName = "Student F";
            studentF.prelim = 90.00;
            studentF.midterm = 90.11;
            studentF.finals = 89.90;
            studentsList.Add(studentF);




            //MeanCalculator.DisplayPrelimMean(studentsList);
            //MeanCalculator.DisplayMidtermMean(studentsList);
            //MeanCalculator.DisplayFinalsMean(studentsList);  


            MedianCalculator.DisplayPrelimMedian(studentsList);
            MedianCalculator.DisplayMidtermMedian(studentsList);
            MedianCalculator.DisplayFinalsMedian(studentsList);

            //foreach (var stud in studentsList)
            //{
            //    Console.WriteLine($"{stud.studentName}: Prelim = {stud.prelim},    Midterm = {stud.midterm}, Finals = {stud.finals}");
            //}

        }
    }
}
