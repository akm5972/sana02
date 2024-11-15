using System;

namespace Sana02
{
    class PointsAverage
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int totalPoints = 0;
            int numOfScores = 5;

            for (int i = 1; i <= numOfScores; i++)
            {
                Console.Write($"Введіть оцінку {i} (0-100): ");
                int score = Convert.ToInt32(Console.ReadLine());
                totalPoints += score;
            }

            double average = totalPoints / (double)numOfScores;

            if (average >= 50)
            {
                Console.WriteLine($"Середній бал: {average}. Студента допущено до екзамену.");
            }
            else
            {
                Console.WriteLine($"Середній бал: {average}. Студента не допущено до екзамену.");
            }
        }
    }
}
