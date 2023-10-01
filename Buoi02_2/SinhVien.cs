using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_2
{
    internal class SinhVien
    {

        public string Khoa { get; set; }
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }

        public SinhVien() { }

        public SinhVien(string msv, string ht, double diem, string khoa)
        {
            this.MaSV = msv;
            this.HoTen = ht;
            this.DiemTB = diem;
            this.Khoa = khoa;
        }

        public SinhVien(SinhVien sinhVien)
        {
            this.MaSV = sinhVien.MaSV;
            this.HoTen = sinhVien.HoTen;
            this.DiemTB = sinhVien.DiemTB;
            this.Khoa = sinhVien.Khoa;
        }
            public void NhapSV()
        {
            Console.Write("Nhập mã số sinh viên  :");
            MaSV = Console.ReadLine();
            Console.Write("Nhập họ tên sinh viên  :");
            HoTen = Console.ReadLine();
            Console.Write("Nhập điểm trung bình sinh viên  :");
            DiemTB = double.Parse(Console.ReadLine());
            Console.Write("Nhập khoa sinh viên :");
            Khoa = Console.ReadLine();

        }

        public void XuatSV()
        {
            Console.WriteLine("{0} \t{1} \t{2} \t{3} \n ", MaSV, HoTen, DiemTB, Khoa);
        }
    }
}