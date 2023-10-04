namespace StatsDLL
{
    public class GradeCalculator
    {
        private static double CalculateFinalPeriod(double prelim, double midterm, double finals)
        {
            double roundedUpFinalGrade = prelim + midterm + finals;
            return Math.Ceiling(roundedUpFinalGrade / 3);
        }

        public static void DisplayGrade(List<StudentModel> students)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------|");
            Console.WriteLine("|                                    Students Grade                                |");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("| Student Name |    Prelim    |    Midterm    |    Finals     |   Final Average    |");
            Console.WriteLine("------------------------------------------------------------------------------------");

            foreach (var student in students)
            {
                double roundDownPrelim = Math.Floor(student.prelim);
                double roundDownMidterm = Math.Floor(student.midterm);
                double roundDownFinals = Math.Floor(student.finals);
                double roundedUpFinalGrade = CalculateFinalPeriod(roundDownPrelim, roundDownMidterm, roundDownFinals);

                Console.WriteLine($"| {student.studentName,-12} | {student.prelim,13:F2} | {student.midterm,13:F2} | {student.finals,13:F2} | {roundedUpFinalGrade,17:F2} |");
                Console.WriteLine("------------------------------------------------------------------------------------");
            }

        }

    }
}
