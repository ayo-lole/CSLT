using System;
using System.IO;

namespace UEH_Green
{
    class GameRanking
    {
        public static string filePath = "xeploai.txt";

        // Hàm tính hạng dựa trên số điểm từ trò chơi chính
        public static string CalculateRank(int score)
        {
            if (score <= 4)
            {
                return "CS1";
            }
            else if (score <= 9)
            {
                return "CS2";
            }
            else if (score <= 14)
            {
                return "CS3";
            }
            else if (score <= 19)
                return "CS4";
            else
            {
                return "Invalid score";
            }
        }

        // Lưu tên, điểm và hạng vào file sau trò chơi
        public static void SaveProgress(string YourName, int score)
        {
            string rank = CalculateRank(score);

            // Thiết lập màu sắc
            Console.ForegroundColor = ConsoleColor.Green;
            int x = Console.WindowWidth / 4;
            int y = Console.WindowHeight / 8;

            // Define the ASCII art with a wider frame to accommodate 22-character names
            string[] art = new string[]
            {
        @"                           cccc@@@\                        ",
        @"               c@@@@@@@@\ /ccccc@@@|                       ",
        @"              /cccccc@@@@@\@ccc@@/ccccccccc                ",
        @"             cccccccccccc@@\@@@/cccccccccc@\               ",
        @"             cccccccccccccc@|/ccccccccccc@@@               ",
        @"              \ccccccccccccc@|ccccccc@@@@@@/               ",
        @"                    \ccccccc@|ccc@@@@@@@@@/                ",
        @"                     ccccccccccccc@@                       ",
        @"                     |             |                       ",
        @"                    /*   Ụ     Ụ   *\                      ",
        @"                   /**      ~      **\                     ",
        @"                   |***           ***|                     ",
        @"||--------------------------------------------------------||",
        @"||                                                        ||",
        @"||       Thua mất rồi! Cố gắng hơn vào lần sau nhé!       ||",
        $@"||           Số điểm cuối cùng của bạn là: {score,-2}              ||",
        @"||--------------------------------------------------------||",
        $@"|| Người chơi: {YourName,-22}           XL: {rank,-3}   ||", // Adjusted for 22-character names
        @"||________________________________________________________||",
        @"        ╔════════════════════════════════════════╗        ",
        @"        ║                                        ║        ",
        @"        ║       >>Nhấn F để xem lịch sử<<        ║        ",
        @"        ║                                        ║        ",
        @"        ╚════════════════════════════════════════╝        ",
            };

            // Đặt con trỏ tại vị trí (x, y)
            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);  // Đặt vị trí dòng tiếp theo
                Console.WriteLine(art[i]);  // In từng dòng của mảng art
                if (art[i].Contains("c" + "@")) // Đặt màu xanh lá cho phần có chữ 'c'
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                }

                else // Đặt màu trắng cho phần còn lại
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            // Write the entire art block to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in art)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
