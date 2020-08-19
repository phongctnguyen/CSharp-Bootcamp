using System;

namespace ArrayAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentGrades = new int [] {15, 8, 5, 7, 22};
            double averageResult = GetAverage(studentGrades);

            foreach(int grade in studentGrades) 
            {
                Console.WriteLine($"{grade}");
            }

            Console.WriteLine($"The average is {averageResult}");
        }

        static double GetAverage(int[] gradeArray)
        {
            int size = gradeArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++) {
                sum += gradeArray[i];
            }

            average = (double)sum / (double)size;
            return average;
        }
    }
}
