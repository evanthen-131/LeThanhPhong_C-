using Buoi02_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<SinhVien> list = NhapDSSinhVien();
            Console.Write("Danh sách sinh viên : ");
            XuatDSSinhVien(list);
            Console.Write("sinh viên khoa CNTT: ");
            DSSVCNTT(list);
            Console.Write("sinh viên khoa điểm tb > 5: ");
            DSSVLONHON5(list);
            Console.Write("sinh viên có điểm tăng dần : ");
            DSSVSAPXEP(list);
            Console.ReadKey();
        }

        private static List<SinhVien> NhapDSSinhVien()
        {
            List<SinhVien> listSV = new List<SinhVien>();
            Console.Write("Nhập tổng số sinh viên : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ========== Nhập danh sách sinh viên =========");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập sinh viên thứ {0}:", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSV.Add(sv);
            }
            return listSV;
        }
        private static void XuatDSSinhVien(List<SinhVien> listSV)
        {
            Console.WriteLine("=====> Xuất danh sách >====");
            foreach (SinhVien sv in listSV)
            {
                sv.XuatSV();
            }
        }
        private static void DSSVCNTT(List<SinhVien> listSV)
        {

            List<SinhVien> ListCNTT1 = listSV.Where(p => p.Khoa == "CNTT").ToList();
            List<SinhVien> ListCNTT2 = (from s in listSV where s.Khoa == "CNTT" select s).ToList();
            if (ListCNTT1.Count() == 0)
            {

                Console.WriteLine("Không có sinh viên khoa CNTT");

            }
            else
            {
                XuatDSSinhVien(ListCNTT1);
            }
            if (ListCNTT2.Count() == 0)
            {
                Console.WriteLine("Không có sinh viên khoa CNTT");
            }
            else
            {
                XuatDSSinhVien(ListCNTT2);
            }
        }

        private static void DSSVLONHON5(List<SinhVien> listSV)
        {
            List<SinhVien> svLH5 = listSV.Where(p => p.DiemTB >= 5).ToList();
            if (svLH5.Count() == 0)
            {
                Console.WriteLine(" Không có học sinh nào >= 5 điểm "); 

            }
            else
            {
                XuatDSSinhVien(svLH5);
            }
        }

        private static void DSSVSAPXEP(List<SinhVien> listSV)
        {
            List<SinhVien> dssapxep = listSV.OrderBy(p => p.DiemTB).ToList();
            XuatDSSinhVien(dssapxep);
        }
    }
}