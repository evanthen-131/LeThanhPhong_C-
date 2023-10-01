using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();

            Console.WriteLine("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap ten sinh vien thu " + (i + 1) + ": ");
                string studentName = Console.ReadLine();
                students.Add(studentName);
            }

            Console.WriteLine("Danh sach sinh vien:");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();
        }
    }

}