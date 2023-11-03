using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_06

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            PhuongTrinhBacHai(a, b, c);
        }
        static void PhuongTrinhBacHai(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co hai ngiem phan biet:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co mot ngiem kep:");
                Console.WriteLine($"x = {x}");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo ngiem.");
            }
        }

      
    }

}
