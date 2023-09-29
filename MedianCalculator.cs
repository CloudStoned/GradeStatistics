using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvStatics
{
    public class MedianCalculator
    {
        private static List<StudentModel>SortStudentList(List<StudentModel> students, Func<StudentModel, double> termSelector)
        {
            var sortedStudentList = students.OrderBy(termSelector).ToList();
            return sortedStudentList;
        }

        private static double CalculateMedian(List<StudentModel> studentList, Func<StudentModel, double> termSelector)
        {
            var sortedStudentList = SortStudentList(studentList, termSelector);
            int count = sortedStudentList.Count;
            double median;

            if (count % 2 == 0)
            {
                double value1 = termSelector(sortedStudentList[count / 2 - 1]);
                double value2 = termSelector(sortedStudentList[count / 2]);
                median = (value1 + value2) / 2.0;

            } 

            else
            {
                median = termSelector(sortedStudentList[count / 2]);
            }

 
            
            return median;
        }

        public static void DisplayPrelimMedian(List<StudentModel> students)
        {
            double prelimMedian = CalculateMedian(students, student => student.prelim);
            Console.WriteLine($"Prelim Median: {prelimMedian:F3}");
        }

        public static void DisplayMidtermMedian(List<StudentModel> students)
        {
            double midtermMedian = CalculateMedian(students, student => student.midterm);
            Console.WriteLine($"Midterm Median: {midtermMedian:F3}");
        }

        public static void DisplayFinalsMedian(List<StudentModel> students)
        {
            double finalsMedian = CalculateMedian(students, student => student.finals);
            Console.WriteLine($"Finals Median: {finalsMedian:F3}");
        }





    }
}
