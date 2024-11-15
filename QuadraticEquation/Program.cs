using System;

namespace Sana02
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть коефіцієнт a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть коефіцієнт b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть коефіцієнт c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Корені рівняння: x1 = {x1}, x2 = {x2}");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Єдиний корінь рівняння: x = {x}");
            }
            else
            {
                Console.WriteLine("Коренів немає.");
            }
        }
    }
}
