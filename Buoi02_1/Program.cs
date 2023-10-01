using Buoi02_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Nhập tổng số sinh viên  :");
            int n = Convert.ToInt32(Console.ReadLine());
            SinhVien[] arrSinhVien = new SinhVien[n];
            Console.WriteLine("\n =====> Nhập danh sách sinh viên <=======");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập sinh viên thứ {0}_", i + 1);
                arrSinhVien[i] = new SinhVien();
                arrSinhVien[i].NhapSV();
            }
            Console.WriteLine("\n =====> Xuất danh sách <=====");
            foreach (SinhVien sv in arrSinhVien)
            {
                sv.XuatSV();
            }
            Console.ReadKey();
        }
    }
}