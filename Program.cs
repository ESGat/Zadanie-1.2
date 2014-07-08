using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты вершин трекгольника. ");
            Console.WriteLine("Введите координату xa первой вершины: ");
            Double xa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату ya первой вершины: ");
            Double ya = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату xb второй вершины: ");
            Double xb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату yb второй вершины");
            Double yb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату xc третьей вершины: ");
            Double xc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату yc третьей вершины: ");
            Double yc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату xm точки М ");
            Double xm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату ym точки М ");
            Double ym = Convert.ToDouble(Console.ReadLine());

            Double a = Math.Sqrt((xb - xa) + (yb - xa));
            Double b = Math.Sqrt((xc - xb) + (yc - yb));
            Double c = Math.Sqrt((xa - xc) + (ya - yc));

            Double p = ((a + b + c) / 2);
            Double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Double d = Math.Sqrt((xm - xa) + (ym - ya));
            Double e = Math.Sqrt((xm - xb) + (ym - yb));
            Double f = Math.Sqrt((xm - xc) + (ym - yc));

            Double p1 = ((a + d + e) / 2);
            Double s1 = Math.Sqrt(p1 * (p1 - a) * (p1 - d) * (p1 - e));

            Double p2 = ((b + f + e) / 2);
            Double s2 = Math.Sqrt(p2 * (p2 - b) * (p2 - e) * (p2 - f));

            Double p3 = ((c + d + f) / 2);
            Double s3 = Math.Sqrt(p3 * (p3 - c) * (p3 - d) * (p3 - f));

            Double S123 = s1 + s2 + s3;

            if (S < S123)
            {
                Console.WriteLine("Точка не лежит внутри треугольника. ");
            }
            else
            {
                Console.WriteLine("Точка лежит внутри треугольника. ");
            }

            Console.ReadKey();

        }
    }
}
