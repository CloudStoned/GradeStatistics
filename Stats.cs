﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvStatics
{
    public class StatsCalculator
    {
        private static double CalculateMean(List<StudentModel> studentList, Func<StudentModel, double> termSelector)
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
            Console.Write($"Prelim Mean: {prelimMean:F2}");
        }

        public static void DisplayMidtermMean(List<StudentModel> studentList)
        {
            Console.WriteLine();
            double midtermMean = CalculateMean(studentList, student => student.midterm);
            Console.Write($"Midterm Mean: {midtermMean:F2}");
        }

        public static void DisplayFinalsMean(List<StudentModel> studentList)
        {
            Console.WriteLine();
            double finalsMean = CalculateMean(studentList, student => student.finals);
            Console.Write($"Finals Mean: {finalsMean:F2}");
        }
    }
}