using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvStatics
{
    public class MedianCalculator
    {
        private static List<StudentModel>SortStudentList(List<StudentModel> students)
        {
            var sortedStudentList = students.OrderBy(student => student.prelim).ToList();
            return sortedStudentList;
        }

        //private static List<StudentModel> CalculateMedian(List<StudentModel> studentList, Func<StudentModel, double> termSelector)
        //{
        //    var sortedStudentList = SortStudentList(studentList); 
        //    int count = sortedStudentList.Count;

        //    if (count % 3 == 0) 
        //    {

        //    }

        //    return sortedStudentList;
        //}

        public static void CalculateMedian(List<StudentModel> studentList)
        {
            var sortedStudentList = SortStudentList(studentList); 
            int count = sortedStudentList.Count;

            if (count % 2 == 0) // Even-sized dataset
            {
                Console.WriteLine("Even Number");
                Console.WriteLine(count);

                // Calculate the median for even-sized dataset
                double median = (sortedStudentList[count / 2 - 1].prelim + sortedStudentList[count / 2].prelim) / 2.0;

                Console.WriteLine("Median:");
                Console.WriteLine(median);
            }

            else // Odd-sized dataset
            {
                Console.WriteLine("Odd Number");
                Console.WriteLine(count);

                // Calculate the median for odd-sized dataset
                double median = sortedStudentList[count / 2].prelim;

                Console.WriteLine("Median:");
                Console.WriteLine(median);
            }


            //return sortedStudentList;
        }

        //public static void DisplayPrelimMedian(List<StudentModel> students)
        //{
        //    var sortedList = CalculateMedian(students, student => student.prelim);

        //    Console.WriteLine("Sorted List:");
        //    foreach (var student in sortedList)
        //    {
        //        Console.WriteLine(student.prelim);
        //    }

        //    Console.WriteLine($"{students.Count} Data");
        //}
    }
}
