using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 2;
            const int m = 3;
            int[,] array = new int[n, m];
            int a, b, c, a1, b1, c1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Введите {j + 1} сторону {i + 1} треугольника: ");
                    array[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            a = array[0, 0]; b = array[0, 1]; c = array[0, 2];
            a1 = array[1, 0]; b1 = array[1, 1]; c1 = array[1, 2];
            double S = CalcArea(a, b, c);
            double S1 = CalcArea(a1, b1, c1);
            if (S > S1)
                Console.WriteLine("Площадь 1го треугольника больше и равна S = {0:f2}", S);
            else if (S == S1)
                Console.WriteLine("Площади треугольников с указанными сторонами равны между собой, S = {0:f2}", S);
            else
                Console.WriteLine("Площадь 2го треугольника больше и равна S = {0:f2}", S1);
            Console.ReadKey();
        }
        static double CalcArea(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
    }
}
