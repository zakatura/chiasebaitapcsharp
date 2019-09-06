using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongHieuTichPhuong
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BÀI TẬP SỐ 1 : Viết Chương Trình Tính Tổng, Hiệu, Tích, Phương : Bằng kiến thức về Console.WriteLine và Các loại Biến, Các loại ép Biến 

            int A, B;                       // Biến chứa 2 số vừa nhập vào ( Kiểu Số )
            int Tong, Hieu, Tich;           // Biến chứa kết quả
            double Thuong;                  // Riêng vì phép chia có số thập phân nên dùng biến kiểu Double để chứa nó
            string strA, strB;              // Biến chứa giá trị 2 số nhập vào từ bàn phím
            bool check;                     // Biến True - False để check xem có phải Int hay không, nếu không phải thì xử lý sau 

            Console.WriteLine("                                                                     ");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*                                                                   *");
            Console.WriteLine("*                       TONG ~ HIEU  ~ TICH ~ PHUONG                *");
            Console.WriteLine("*                                                                   *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("                                                                     ");

            Console.Write(" Moi ban nhap so dau tien : ");
            strA = Console.ReadLine();      // Nhập giá trị A từ bàn phím, dùng Readline thay vì Readkey không thì hỏng hết =))
            check = int.TryParse(strA, out A);
            Console.Write(check == true ? "\n" : "\n Vi Ban Nhap Sai Nen So Dau Tien Duoc Xem La : 0 \n \n");

            Console.Write(" Moi ban nhap so thu hai  : ");
            strB = Console.ReadLine();      // Nhập giá trị B từ bàn phím
            check = int.TryParse(strB, out B);
            Console.Write(check == true ? "\n" : "\n Vi Ban Nhap Sai Nen So Thu Hai Duoc Xem La  : 0\n \n");
            Console.WriteLine("                                                                     ");

            Tong = A + B;
            Hieu = A - B;
            Tich = A * B;
            Thuong = (double)A / B;         // Ép kiểu A về dạng số thập phân để phép chia cho ra số thập phân thành công
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*                                                                   *");
            Console.WriteLine("* Ket Qua La :                                                       ");
            Console.WriteLine("*    Tong   = " + Tong);
            Console.WriteLine("*    Hieu   = " + Hieu);
            Console.WriteLine("*    Tich   = " + Tich);
            Console.WriteLine("*    Thuong = " + Thuong);
            Console.WriteLine("*                                                                   *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*                                                                   *");
            Console.WriteLine("*                            XIN CAM ON                             *");
            Console.WriteLine("*                                                                   *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("                                                                     ");

            Console.ReadKey();
            #endregion
        }
    }
}
