using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvStatics
{
    public class GetMean
    {
        private static double CalculatMean(List<StudentModel> studentList)
        {
            double sum = 0;
            int counter = 0;
            double mean;

            foreach (var student in studentList)
            {
                sum += student.prelim;
                counter++;
            }

            mean = sum / counter;

            return mean;
        }

        public static void DisplayPrelimMean(List<StudentModel> studentList)
        {
            Console.Write("Prelim Mean");
            double prelimMean = CalculatMean(studentList);
            Console.Write($"Prelim Mean: {prelimMean:2F}");
        }

        public static void DisplayMidtermMean(List<StudentModel> studentList)
        {
            double midtermMean = CalculatMean(studentList);
            Console.Write($"Midterm Mean: {midtermMean:2F}");
        }
    }
}
