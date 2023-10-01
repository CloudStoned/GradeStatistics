

namespace AdvStatics.Statistics
{
    public class ModeCalculator
    {
        private static double HasMode(List<StudentModel> studentList, Func<StudentModel, double> termSelector)
        {
            double currentValue = termSelector(studentList[0]);
            int consecutiveCount = 1;

            for (int i = 1; i < studentList.Count; i++)
            {
                double nextValue = termSelector(studentList[i]);

                if (currentValue == nextValue)
                {
                    consecutiveCount++;
                }
                else
                {
                    consecutiveCount = 1;
                }

                if (consecutiveCount > 1)
                {
                    return currentValue;
                }

                currentValue = nextValue;
            }

            return 0;
        }

        public static void DisplayPrelimMode(List<StudentModel> studentList)
        {
            double prelimMode = HasMode(studentList, student => student.prelim);
            Console.WriteLine($"Prelim Mode : {prelimMode}");
        }

        public static void DisplayMidtermMode(List<StudentModel> studentList)
        {
            double midtermMode = HasMode(studentList, student => student.midterm);
            Console.WriteLine($"Midterm Mode: {midtermMode}");
        }

        public static void DisplayFinalsMode(List<StudentModel> studentList)
        {
            double finalsMode = HasMode(studentList, student => student.finals);
            Console.WriteLine($"Finals Mode : {finalsMode}");
        }

    }
}
