using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvStatics
{
    public class VarianceCalculator: MeanCalculator
    {
        private static double CalculateVariance(List<StudentModel> studentList, Func<StudentModel, double> termSelector)
        {
            double mean = CalculateMean(studentList, termSelector);
            double summationOfPower = 0;
            int counter = studentList.Count;

            foreach (StudentModel student in studentList) 
            {
                double value = termSelector(student);
                Console.WriteLine(value);
                Console.WriteLine(mean);
                double differenceOfValue = value - mean;
                summationOfPower = Math.Pow(2.0, differenceOfValue);
            }

            double variance = summationOfPower / (mean - counter);

            return variance;
        }

        public static void DisplayPrelimVariance(List<StudentModel> studentList) 
        {
            double prelimVariance = CalculateVariance(studentList, student => student.prelim);
            Console.WriteLine($"Prelim Variance: {prelimVariance}");
        }

    }
}
