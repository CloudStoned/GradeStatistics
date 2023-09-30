using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvStatics
{
    public  class GradeCalculator
    {
        
        private static double CalculateFinalPeriod (double prelim, double midterm, double finals)
        {
            double roundedUpFinalGrade = prelim + midterm + finals;

            return Math.Ceiling(roundedUpFinalGrade / 3);
        }
        

        public static void DisplayGrade(List<StudentModel> studentList)
        {
            foreach (StudentModel student in studentList)
            {
                
                double roundDownPrelim = Math.Floor(student.prelim);
                double roundDownMidterm = Math.Floor(student.midterm);
                double roundDownFinals = Math.Floor(student.finals);
                double roundedUpFinalGrade = CalculateFinalPeriod(roundDownPrelim, roundDownMidterm, roundDownFinals);
                
                Console.WriteLine(student.studentName);
                Console.WriteLine($"Prelim : {roundDownPrelim}");
                Console.WriteLine($"Midterm: {roundDownMidterm}");
                Console.WriteLine($"Finals : {roundDownFinals}");
                Console.WriteLine($"Final Average : {roundedUpFinalGrade}");


                Console.WriteLine(); 
            }
        }
    }
}

