using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvStatics
{
    public class MedianCalculator
    {
        private static (List<StudentModel>, int countData) SortStudentList(List<StudentModel> students)
        {
            int count = 0;
            var sortedStudentList = students.OrderBy(student => student.prelim).ToList();
            count = sortedStudentList.Count;

            return (sortedStudentList, count);
        }

        private static List<StudentModel> CalculateMedian(List<StudentModel> studentList, Func<StudentModel, double> termSelector)
        {
            var sortedList = SortStudentList(studentList).Item1; // Extract the sorted list from the tuple

            // Implement median calculation logic here if needed

            return sortedList;
        }

        public static void DisplayPrelimMedian(List<StudentModel> students)
        {
            var sortedList = CalculateMedian(students, student => student.prelim);

            Console.WriteLine("Sorted List:");
            foreach (var student in sortedList)
            {
                Console.WriteLine(student.prelim);
            }

            Console.WriteLine($"{students.Count} Data");
        }
    }
}
