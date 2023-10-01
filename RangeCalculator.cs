using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvStatics
{
    public class RangeCalculator
    {
        private static double CalculateRange(List<StudentModel> students, Func<StudentModel, double> termSelector)
        {
            double max = students.Max(termSelector);
            double min = students.Min(termSelector);

            return max - min;
            
        }

        public static void DisplayPrelimRange(List<StudentModel> students) 
        {
            double prelimRange = CalculateRange(students, student => student.prelim);
            Console.WriteLine($"Prelim Median: {prelimRange:F2}");
        }

        public static void DisplayMidtermRange(List<StudentModel> students)
        {
            double midtermRange = CalculateRange(students, student => student.midterm);
            Console.WriteLine($"Midterm Range: {midtermRange:F2}");
        }

        public static void DisplayFinalsRange(List<StudentModel> students)
        {
            double finalsRange = CalculateRange(students, student => student.finals);
            Console.WriteLine($"Finals Range: {finalsRange:F2}");
        }
    }
}
