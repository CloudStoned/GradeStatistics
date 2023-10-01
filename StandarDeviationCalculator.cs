using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvStatics
{
    public class StandarDeviationCalculator: VarianceCalculator
    {
        private static double CalculateStandardDeviation(List<StudentModel> studentList, Func<StudentModel, double> termSelector)
        {
            double variance = CalculateVariance(studentList, termSelector);
            return Math.Sqrt(variance);
        }

        public static void DisplayPrelimStandardDeviation(List<StudentModel> studentList)
        {
            double prelimSd = CalculateStandardDeviation(studentList, student => student.prelim);
            Console.WriteLine($"Prelim Standard Deviation: {prelimSd:F3}");
        }

        public static void DisplayMidtermStandardDeviation(List<StudentModel> studentList)
        {
            double midtermSd = CalculateStandardDeviation(studentList, student => student.midterm);
            Console.WriteLine($"Midterm Standard Deviation: {midtermSd:F3}");
        }

        public static void DisplayFinalsStandardDeviation(List<StudentModel> studentList)
        {
            double finalsSd = CalculateStandardDeviation(studentList, student => student.finals);
            Console.WriteLine($"Finals Standard Deviation: {finalsSd:F3}");
        }


    }
}
