using AdvStatics.Statistics;
using AdvStatics.Design;

namespace AdvStatics
{
    public class Program
    {
        static void Main(string[] args) 
        {
            List<StudentModel> studentsList = new List<StudentModel>();

            StudentModel studentA = new StudentModel();
            studentA.studentName = "Student A";
            studentA.prelim = 78.88;
            studentA.midterm = 85.00;
            studentA.finals = 100.00;
            studentsList.Add(studentA);

            StudentModel studentB = new StudentModel();
            studentB.studentName = "Student B";
            studentB.prelim = 56.76;
            studentB.midterm = 98.00;
            studentB.finals = 100.00;
            studentsList.Add(studentB);

            StudentModel studentC = new StudentModel();
            studentC.studentName = "Student C";
            studentC.prelim = 98.00;
            studentC.midterm = 87.92;
            studentC.finals = 99.00;
            studentsList.Add(studentC);

            StudentModel studentD = new StudentModel();
            studentD.studentName = "Student D";
            studentD.prelim = 87.98;
            studentD.midterm = 85.00;
            studentD.finals = 98.00;
            studentsList.Add(studentD);

            StudentModel studentE = new StudentModel();
            studentE.studentName = "Student E";
            studentE.prelim = 89.00;
            studentE.midterm = 90.15;
            studentE.finals = 97.00;
            studentsList.Add(studentE);

            StudentModel studentF = new StudentModel();
            studentF.studentName = "Student F";
            studentF.prelim = 90.00;
            studentF.midterm = 90.11;
            studentF.finals = 89.90;
            studentsList.Add(studentF);

            bool shouldExit = false;

            while (!shouldExit)
            {
                Console.WriteLine();
                Console.WriteLine("Enter Number");
                Console.WriteLine("1 - Mean");
                Console.WriteLine("2 - Median");
                Console.WriteLine("3 - Mode");
                Console.WriteLine("4 - Variance");
                Console.WriteLine("5 - Standard Deviation");
                Console.WriteLine("6 - Range");
                Console.WriteLine("7 - Student Grades");
                Console.WriteLine("8 - Exit");

                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.Clear();
                        DataTableDesign.DisplayData(studentsList);
                        MeanCalculator.DisplayPrelimMean(studentsList);
                        MeanCalculator.DisplayMidtermMean(studentsList);
                        MeanCalculator.DisplayFinalsMean(studentsList);
                        break;

                    case 2:
                        Console.Clear();
                        DataTableDesign.DisplayData(studentsList);
                        MedianCalculator.DisplayPrelimMedian(studentsList);
                        MedianCalculator.DisplayMidtermMedian(studentsList);
                        MedianCalculator.DisplayFinalsMedian(studentsList);
                        break;

                    case 3:
                        Console.Clear();
                        DataTableDesign.DisplayData(studentsList);
                        ModeCalculator.DisplayPrelimMode(studentsList);
                        ModeCalculator.DisplayMidtermMode(studentsList);
                        ModeCalculator.DisplayFinalsMode(studentsList);
                        break;

                    case 4:
                        Console.Clear();
                        DataTableDesign.DisplayData(studentsList);
                        VarianceCalculator.DisplayPrelimVariance(studentsList);
                        VarianceCalculator.DisplayMidtermVariance(studentsList);
                        VarianceCalculator.DisplayFinalsVariance(studentsList);
                        break;

                    case 5:
                        Console.Clear();
                        DataTableDesign.DisplayData(studentsList);
                        StandarDeviationCalculator.DisplayPrelimStandardDeviation(studentsList);
                        StandarDeviationCalculator.DisplayMidtermStandardDeviation(studentsList);
                        StandarDeviationCalculator.DisplayFinalsStandardDeviation(studentsList);
                        break;

                    case 6:
                        Console.Clear();
                        DataTableDesign.DisplayData(studentsList);
                        RangeCalculator.DisplayPrelimRange(studentsList);
                        RangeCalculator.DisplayMidtermRange(studentsList);
                        RangeCalculator.DisplayFinalsRange(studentsList);
                        break;

                    case 7:
                        Console.Clear();
                        GradeCalculator.DisplayGrade(studentsList);
                        break;

                    case 8:
                        shouldExit = true;  
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }
            }
        }
    }
}
