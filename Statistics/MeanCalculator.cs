

namespace AdvStatics.Statistics
{
    public class MeanCalculator
    {
        public static double CalculateMean(List<StudentModel> studentList, Func<StudentModel, double> termSelector)
        {

            double sum = 0;
            int counter = 0;
            double mean;

            foreach (var student in studentList)
            {
                double value = termSelector(student);
                sum += value;
                counter++;
            }

            mean = sum / counter;

            return mean;
        }

        public static void DisplayPrelimMean(List<StudentModel> studentList)
        {
            double prelimMean = CalculateMean(studentList, student => student.prelim);
            Console.WriteLine($"Prelim Mean: {prelimMean:F3}");
        }

        public static void DisplayMidtermMean(List<StudentModel> studentList)
        {
            double midtermMean = CalculateMean(studentList, student => student.midterm);
            Console.WriteLine($"Midterm Mean: {midtermMean:F3}");
        }

        public static void DisplayFinalsMean(List<StudentModel> studentList)
        {

            double finalsMean = CalculateMean(studentList, student => student.finals);
            Console.WriteLine($"Finals Mean: {finalsMean:F3}");
        }
    }
}
