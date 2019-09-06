using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTuoiNguoiDungVaNhanXet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BÀI TẬP SỐ 2 : Viết chương trình nhập vào một số tương ứng là năm. Xuất ra màn hình năm vừa nhập và tuổi tương ứng với năm đó. Sau đó cho ra kết quả dựa theo tuổi và in ra màn hình


            int NamHienTai = DateTime.Now.Year;                             // Biến của Năm được gọi chính xác theo hệ thống, không cần nhập vào
            int NamSinh, Tuoi;                                              // Biến của Năm Sinh và Tuổi
            string NhapNamSinh;                                             // Biến của Năm Sinh nhập từ người dùng

            Console.Write("\nMoi Ban Nhap Nam Sinh Theo Dang : YYYY : ");
            NhapNamSinh = Console.ReadLine();

            if (int.TryParse(NhapNamSinh, out NamSinh))
            {
                Tuoi = NamHienTai - NamSinh;
                Console.WriteLine("\nVay Nam Nay Ban Se : " + Tuoi + " Tuoi \n");

                if (-1 < Tuoi && Tuoi < 16)
                {
                    Console.WriteLine("Ban Con La Vi Thanh Nien :> ");
                }
                else if (17 < Tuoi && Tuoi < 55)
                {
                    Console.WriteLine("Ban Da La Nguoi Truong Thanh");
                }
                else if (56 < Tuoi && Tuoi < 120)
                {
                    Console.WriteLine("Kinh Chao Cu Ong Cu Ba");

                }
                else
                {
                    Console.WriteLine("Ban Dang Tu Tien Dung Khong ?");
                }
            }
            else
            {
                Console.WriteLine("\nBan Nhap Sai Dinh Dang, Chuong Trinh Loi, Xin Thoat !");
            };

            Console.ReadKey();
            Console.WriteLine();
            #endregion
        }
    }
}
