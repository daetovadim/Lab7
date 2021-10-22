using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба: ");
            int a = Int32.Parse(Console.ReadLine());
            CubicParams(a, out double A, out double V);
            Console.WriteLine("Площадь поверхности куба равна: {0:.00}", A);
            Console.WriteLine("Объём куба равен: {0:.00}", V);
            Console.ReadKey();
        }
        static void CubicParams(int a, out double A, out double V)
        {
            A = 6 * a * a;
            V = a * a * a;
        }
    }
}
