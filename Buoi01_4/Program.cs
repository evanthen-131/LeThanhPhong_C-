using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao 3 so nguyen b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao 3 so nguyen c:");
            int c = int.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Cac so nguyen phai lon hon 0.");
                return;
            }

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Day la 3 canh cua mot tam giac.");

                int chuVi = a + b + c;
                double p = chuVi / 2.0;
                double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine($"Chu vi tam giac la {chuVi}.");
                Console.WriteLine($"Dien tich tam giac la {dienTich}.");
            }
            else
            {
                Console.WriteLine("Day khong phai la 3 canh cua mot tam giac");
            }
            Console.ReadKey();
        }
    }

}