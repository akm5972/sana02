using System;


namespace Sana02
{
    class WhileSequences
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть натуральне число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double a = CalculateA(n);
            double b = CalculateB(n);
            int c = CalculateC(n);

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
        }

        static double CalculateA(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-1, i) / (2 * i + 1);
            }
            return sum;
        }

        static double CalculateB(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 + 1.0 / (i * i);
            }
            return sum;
        }

        static int CalculateC(int n)
        {
            int factorialSum = 0;
            for (int i = 1; i <= n; i++)
            {
                factorialSum += Factorial(i);
            }
            return factorialSum;
        }

        static int Factorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
