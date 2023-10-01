using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_1
{
    internal class SinhVien
    {
        private string _MaSV;
        public string MaSV
        {
            get { return _MaSV; }
            set { _MaSV = value; }

        }
        private string _HoTen;
        public string HoTen
        {
            get { return _HoTen; }
            private set { _HoTen = value; }
        }
        private double _DiemTB;
        public double DiemTB
        {
            get { return _DiemTB; }
            private set { _DiemTB = value; }
        }
        private string _Khoa;
        public string Khoa
        {
            get { return _Khoa; }
            private set { _Khoa = value; }
        }
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
            Console.WriteLine("{0} \t{1} \t{2} \t{3} \n", MaSV, HoTen, DiemTB, Khoa);
        }
    }
}