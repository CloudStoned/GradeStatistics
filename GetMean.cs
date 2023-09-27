using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvStatics
{
    public class GetMean
    {
        private static double CalculateMean(List<StudentModel> studentList)
        {
            double sum = 0;
            int counter = 0;
            double mean;

            foreach (var student in studentList)
            {
                //Console.WriteLine(student.prelim);
                sum += student.prelim;
                counter++;
            }

            mean = sum / counter;

            return mean;
        }

        public static void DisplayPrelimMean(List<StudentModel> studentList)
        {
            Console.Write("Prelim Mean");
            double prelimMean = CalculateMean(studentList);
            Console.Write($"Prelim Mean: {prelimMean:F2}");
        }

        public static void DisplayMidtermMean(List<StudentModel> studentList)
        {

        }
    }
}
