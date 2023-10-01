

namespace AdvStatics.Statistics
{
    public class VarianceCalculator : MeanCalculator
    {
        public static double CalculateVariance(List<StudentModel> studentList, Func<StudentModel, double> termSelector)
        {
            double mean = CalculateMean(studentList, termSelector);
            int counter = studentList.Count;
            double summationOfSquared = 0;

            foreach (StudentModel student in studentList)
            {
                double value = termSelector(student);
                double differenceOfValue = value - mean;
                double differenceSquared = differenceOfValue * differenceOfValue;
                summationOfSquared = summationOfSquared + differenceSquared;

            }
            double variance = summationOfSquared / (counter - 1);

            return variance;
        }

        public static void DisplayPrelimVariance(List<StudentModel> studentList)
        {
            double prelimVariance = CalculateVariance(studentList, student => student.prelim);
            Console.WriteLine($"Prelim Variance: {prelimVariance:F3}");
        }

        public static void DisplayMidtermVariance(List<StudentModel> studentList)
        {
            double midtermVariance = CalculateVariance(studentList, student => student.midterm);
            Console.WriteLine($"Midterm Variance: {midtermVariance:F3}");
        }

        public static void DisplayFinalsVariance(List<StudentModel> studentList)
        {
            double finalsVariance = CalculateVariance(studentList, student => student.finals);
            Console.WriteLine($"Midterm Variance: {finalsVariance:F3}");
        }



    }
}
