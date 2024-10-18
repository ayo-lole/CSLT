using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEH_Green
{
    internal class UehQuestionHandle
    {
        public static void PositionAtBottom()
        {
            int windowHeight = Console.WindowHeight;
            int bottomPosition = windowHeight = 17; //Đặt vị trí câu hỏi trên màn hình console. Giới hạn khung hình hiện câu hỏi 

            Console.SetCursorPosition(0, bottomPosition);
        }
        public static void ClearQuestionAndAnswer(int startLine, int lineCount)
        {
            for (int i = 0; i < lineCount + 2 ; i++) //Đếm số dòng sẽ xóa
            {
                Console.SetCursorPosition(0, startLine + i); //Đặt con trỏ chuột tại từ vị trí in câu hỏi ra đến xuống dòng trả lời
                Console.Write(new string(' ', Console.WindowWidth));
            }
            Console.SetCursorPosition(0, startLine);
        }
    }
}
