using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeoBuaBao
{
    class Program
    {
        static void Main(string[] args)
        {
			#region BÀI TẬP SỐ 3 : Viết chương trình chơi Kéo Búa Bao 

            //Gợi Ý : Người dùng sẽ nhập vào các số 1 hoặc 2 hoặc 3 tương ứng với kéo hoặc búa hoặc bao. Máy sẽ ngẫu nhiên sinh ra một số trong 3 số và tính toán máy hoặc người chiến thắng. 
            //        Nhớ phải in kết quả ra màn hình.
            // 1 Keo |  2 Bua  |  3 Bao

            int playerChon;
            Random randomAI = new Random();
            int aiChon = randomAI.Next(1, 4);
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("Nao Hay Choi Tro Keo - Bua - Bao : ");
            Console.WriteLine("[1] Keo");
            Console.WriteLine("[2] Bua");
            Console.WriteLine("[3] Bao");
            Console.Write("Hay Trong So 1 - 2 - 3 : Tuong Ung Voi Keo - Bua - Bao : "); playerChon = int.Parse(Console.ReadLine());

            if (playerChon - aiChon == -2)     // Bạn chọn 1 máy chọn 3 tương đương : Bạn Chọn Kéo - Máy Chọn Bao = -2
            {
                Console.WriteLine("\nBan Chon Keo vs May Chon Bao : Ban Thang =)");
            }
            else if (playerChon - aiChon == 1)  // Tương tự như trên nhưng ở đây là  : Bạn Chọn Bao - Máy Chọn Búa = 1
            {
                Console.WriteLine("\nBan Chon Bao vs May Chon Bua : Ban Thang =)");
            }
            else if (playerChon - aiChon == -1)
            {
                Console.WriteLine("\nBan Chon Keo vs May Chon Bua : Ban Thua =(");
            }
            else if (playerChon - aiChon == 2)
            {
                Console.WriteLine("\nBan Chon Bao vs May Chon Keo : Ban Thua =(");
            }
            else if (playerChon - aiChon == 0) // Bạn và máy chọn giống nhau nên hòa 
            {
                Console.WriteLine("\nBan Hoa =|");
            }
            else
            {
                Console.WriteLine("\nBan Nhap Sai Dinh Dang, Chuong Trinh Loi, Xin Thoat !"); // Trừ trường hợp nhập khác số 1 2 3 
            }

            Console.ReadKey();
            #endregion
        }
    }
}
