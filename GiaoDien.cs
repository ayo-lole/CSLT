using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UEH_Green
{
    internal class GiaoDien
    {
        public void DisplayIntro()
        {

            string[] introArt = new string[]
            {
            @"╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗",
            @"║                                                                                                                      ║",
            @"║                                               /$$$$$       /$$                     /$$ /$                            ║",
            @"║                                              /$$/ \$$     /$$/                    /$$ $ $                            ║",
            @"║                                             |_/    \_/   |__/                    |__/\_/                             ║",
            @"║                                                                                                                      ║",
            @"║                 / $$$$$$ / $$  / $$/ $$$$$$/ $$$$$$$$/ $$  / $$          /$$$$$$ / $$$$$$                            ║",
            @"║                / $$__  $$| $$  | $$|_  $$_/| $$_____/| $$$ | $$         /$$__  $$|_  $$_/                            ║",
            @"║                | $$  \__/| $$  | $$  | $$  | $$      | $$$$| $$        | $$  \__/  | $$                              ║",
            @"║                | $$      | $$$$$$$$  | $$  | $$$$$   | $$ $$ $$        |  $$$$$$   | $$                              ║",
            @"║                | $$      | $$__  $$  | $$  | $$__/   | $$  $$$$         \____  $$  | $$                              ║",
            @"║                | $$    $$| $$  | $$  | $$  | $$      | $$\  $$$         /$$  \ $$  | $$                              ║",
            @"║                |  $$$$$$/| $$  | $$ /$$$$$$| $$$$$$$$| $$ \  $$        |  $$$$$$/ /$$$$$$                            ║",
            @"║                 \______/ |__/  |__/|______/|________/|__/  \__/         \______/ |______/                            ║",
            @"║                                                                                                                      ║",
            @"║                     / $$   /$$  /$$$$$$  / $$ / $$/ $$  / $$                   cccc@@@\   cc@@@@@@\                  ║",
            @"║                     | $$  / $$ /$$__  $$| $$$ | $$| $$  | $$                  c@@@@@@@@\ /ccccc@@@|                  ║",
            @"║                     |  $$/ $$/| $$  \ $$| $$$$| $$| $$  | $$                /cccccc@@@@@\@ccc@@/ccccccccc            ║",
            @"║                      \  $$$$/ | $$$$$$$$| $$ $$ $$| $$$$$$$$               cccccccccccc@@\@@@/cccccccccc@\           ║",
            @"║                       >$$  $$ | $$__  $$| $$  $$$$| $$__  $$               cccccccccccccc@|/ccccccccccc@@@           ║",
            @"║                      /$$/\  $$| $$  | $$| $$\  $$$| $$  | $$                \ccccccccccccc@|ccccccc@@@@@@/           ║",
            @"║                     | $$  \ $$| $$  | $$| $$ \  $$| $$  | $$                     \ccccccc@|ccc@@@@@@@@@/             ║",
            @"║                     |__/  |__/|__/  |__/|__/  \__/|__/  |__/                       ccccccccccccc@@                   ║",
            @"║                                             ╔═══════════════════════╗              |             |                   ║",
            @"║                                             ║     >>> Enter <<<     ║             /*   >     <   *\                  ║",
            @"║                                             ╚═══════════════════════╝            /**      0      **\                 ║",
            @"╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝"
            };

            // In ra từng dòng của chữ ASCII
            for (int i = 0; i < introArt.Length; i++)
            {
                if (introArt[i].Contains("c" + "@")) // Đặt màu xanh lá cho phần có chữ 'c'
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                }
                else // Đặt màu trắng cho phần còn lại
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(introArt[i]);
            }
            Console.ResetColor();
        }
        public static string[] Bangmota(int x, int y)
        {
            string[] bangmota = new string[]
            {
                @"                                      ██████╗███████╗██╗  ██╗                                       ",
                @"                                     ██╔════╝██╔════╝╚██╗██╔╝                                       ",
                @"                                     ██║     ███████╗ ╚███╔╝                                        ",
                @"                                     ██║     ╚════██║ ██╔██╗                                        ",
                @"                                     ╚██████╗███████║██╔╝ ██╗                                       ",
                @"                                      ╚═════╝╚══════╝╚═╝  ╚═╝                                       ",
                @"   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━   ",
                @"  |Round 1: Chiến thắng khi bạn trả lời đúng 20 câu hỏi | Round 2: Hành trình của bạn sẽ chỉ kết |  ",
                @"  |   Bộ câu hỏi 1:   10 câu hỏi về phân loại rác       |          thúc khi bạn đã chinh phục    |  ",
                @"  |   Bộ câu hỏi 2:   10 câu hỏi về UEH Green           |          hết các cơ sở của Đại học UEH |  ",
                @"  |----------------------------------------------------------------------------------------------|  ",
                @"  |Luật chơi: Bạn được phép trả lời sai 2 câu. Sai 3 câu trò chơi sẽ kết thúc                    |  ",
                @"  |           Lưu lại bút danh (tối đa 22 kí tự, không vượt qua khung) để ghi nhận thành quả     |  ",
                @"  |           hoàn thành Chiến Sĩ Xanh                                                           |  ",
                @"  |                                                                                              |  ",
                @"  |Xếp loại: CS1(0-4): Tìm hiểu thêm nhé!                                *********************   |  ",
                @"  |          CS2(5-9): Cố gắng vào lần sau!                              * Hoàn thành 20 câu *   |  ",
                @"  |          CS3(10-14): Bạn đã có kiến thức cơ bản về UEH Green rồi!    *     Bạn là CSX    *   |  ",
                @"  |          CS4(15-19): Bạn đã tiến gần đến danh hiệu Chiến Sĩ Xanh!    *********************   |  ",
                @"  |                                                                                              |  ",
                @"   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━   ",
            };

            for (int i = 0; i < bangmota.Length; i++)
            {
                if (bangmota[i].Contains("█"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(bangmota[i]);
            }

            Console.ResetColor();
            return bangmota;
        }
        public static string InputPlayerName()
        {
            // Bảng điền tên 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(40, 23);
            Console.WriteLine("CHÀO MỪNG UEHer ĐẾN VỚI CHIẾN SĨ XANH!");
            string YourName = "";
            bool validInput = false;

            // Kích thước khung (tăng chiều rộng)
            int frameWidth = 40;  // Kéo dài khung ra
            int frameX = 40 - 3;  // Dịch khung sang trái
            int frameY = 23 + 1;

            // Vẽ khung nhập (nằm ngay dưới thông điệp chào mừng)
            void DrawFrame()
            {
                // Vẽ cạnh trên và dưới, đặt khung ngay dưới thông điệp
                Console.SetCursorPosition(frameX, frameY);
                Console.Write("+");
                Console.Write(new string('-', frameWidth));
                Console.Write("+");

                // Vẽ cạnh dưới (ở đây chúng ta chỉ cần một đường vì không có phần trống bên dưới)
                Console.SetCursorPosition(frameX, frameY + 2);
                Console.Write("+");
                Console.Write(new string('-', frameWidth));
                Console.Write("+");
            }

            // Xóa phần nội dung nhập trước
            void ClearFrame()
            {
                Console.SetCursorPosition(frameX + 2, frameY + 1);  // Xóa phần sau "BÚT DANH :"
                Console.Write(new string(' ', Console.WindowWidth - (frameY + 1)));  // Chỉ xóa phần nội dung
            }

            // Gọi hàm vẽ khung
            DrawFrame();

            // Nhập tên với giới hạn 22 ký tự
            while (!validInput)
            {
                Console.SetCursorPosition(frameX + 2, frameY + 1);  // Đặt con trỏ ngay sau "BÚT DANH :"
                Console.Write("BÚT DANH : ");

                YourName = Console.ReadLine();

                if (YourName.Length <= 22 && !string.IsNullOrWhiteSpace(YourName))
                {
                    validInput = true;  // Đầu vào hợp lệ
                }
                else
                {
                    // Xóa dòng nhập trước đó
                    ClearFrame();
                }
            }

            // Xóa thông tin khung và khôi phục màu nền sau khi nhập
            Console.ResetColor();
            Console.Clear();
            return YourName;
        }
        public static void PrintEnterNFBanner()
        {
            string[] banner = new string[]
            {
            @"╔════════════════════════════╗                          ╔═══════════════════════════════╗",
            @"║                            ║                          ║                               ║",
            @"║   >>Nhấn ENTER để CHƠI<<   ║                          ║   >>Nhấn F để XEM LỊCH SỬ<<   ║",
            @"║                            ║                          ║                               ║",
            @"╚════════════════════════════╝                          ╚═══════════════════════════════╝",
            @"                                                                                         ",
            @"                                                                                         ",
            @"                                                                                         ",
            @"                 UEHer                                          UEHer                    ",
            @"                                                                                         ",
            @"                   O /                                           \ O                     ",
            @"                  <|                                               |>                    ",
            @"                  /\                                               /\                    ",
            @"                 |  |                                             |  |                   ",


             };
            Console.ForegroundColor = ConsoleColor.Green;
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;

            // Tính toán vị trí để in banner ra giữa màn hình
            int xPos = (consoleWidth - banner[0].Length) / 4;
            int yPos = (consoleHeight - banner.Length) / 4;

            // In banner ở vị trí đã tính toán
            for (int i = 0; i < banner.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 7, yPos + i);
                Console.WriteLine(banner[i]);
                if (banner[i].Contains("╔" + "═")) // Đặt màu xanh lá 
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                }

                else // Đặt màu vàng đậm cho phần còn lại
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
            }
            Console.ResetColor();
        }
        public static void TinhDiem(int score)
        {
            // Hiển thị điểm
            Console.SetCursorPosition(2, 2); // Đặt vị trí con trỏ cho điểm
            for (int i = 0; i < score; i++)
            {
                Console.Write("🌳 ");
            }
        }
        public static void DrawHealthBar(int health, int maxHealth)
        {
            // Mỗi biểu tượng sức khỏe chiếm 2 ký tự (biểu tượng + khoảng trắng), cộng thêm một khoảng trắng nữa cho đường viền
            int barWidth = maxHealth * 2 + 4; // Tính chiều rộng của thanh sức khỏe bao gồm cả khung

            // Vẽ đường viền trên cùng
            Console.SetCursorPosition(108, 0);
            Console.Write("╔");
            for (int i = 0; i < barWidth; i++) Console.Write("═");
            Console.WriteLine("╗");

            // Vẽ thanh sức khỏe với đường viền bên
            Console.SetCursorPosition(108, 1);
            Console.Write("║ "); // Đường viền bên trái
            for (int i = 0; i < maxHealth; i++)
            {
                if (i < health)
                {
                    Console.Write("❤️ "); // Hiển thị sức khỏe
                }
                else
                {
                    Console.Write("🗑️ "); 
                }
            }
            Console.Write("║"); // Đường viền bên phải
            Console.WriteLine();

            // Đường viền phía dưới 
            Console.SetCursorPosition(108, 2);
            Console.Write("╚");
            for (int i = 0; i < barWidth; i++) Console.Write("═");
            Console.WriteLine("╝");
        }
        public static void PrintArt(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string[] art = new string[]
            {
@"                    cccc@@@\                ",
@"        c@@@@@@@@\ /ccccc@@@|               ",
@"       /cccccc@@@@@\@ccc@@/ccccccccc        ",
@"      cccccccccccc@@\@@@/cccccccccc@\       ",
@"      cccccccccccccc@|/ccccccccccc@@@       ",
@"       \ccccccccccccc@|ccccccc@@@@@@/       ",
@"             \ccccccc@|ccc@@@@@@@@@/        ",
@"              ccccccccccccc@@               ",
@"              |             |               ",
@"             /*   >     <   *\              ",
@"            /**      0      **\             ",
@"            |***           ***|             ",
@" ||--------------------------------------|| ",
@" ||                                      || ",
@" || CHÚC MỪNG BẠN ĐÃ CHIẾN THẮNG ROUND 1 || ",
@" ||                                      || ",
@" ||______________________________________|| ",
@"    ╔═══════════════════════════════════╗   ",
@"    ║  >> Nhấn Enter để qua ROUND 2 <<  ║   ",
@"    ╚═══════════════════════════════════╝   ",
@"      ╔═══════════════════════════════╗     ",
@"      ║  >> Nhấn F để xem LỊCH SỬ <<  ║     ",
@"      ╚═══════════════════════════════╝     ",
};

            // Đặt con trỏ tại vị trí(x, y)
            for (int i = 0; i < art.Length; i++)
            {
                if (art[i].Contains("c" + "@")) // Đặt màu xanh lá cho phần có chữ 'c' và '@'
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (art[i].Contains("══"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                else // Đặt màu trắng cho phần còn lại
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(art[i]);
            }
            Console.ResetColor();
        }
        public void DisplayPrintWinArt()
        {
            string[] WinArt = new string[]
            {
            @"╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗",
            @"║ccccccccccccccccc@@@@@@cccccccccccccccccc@@@@@@                                             ██╗                       ║",
            @"║cccccccccccccccccc@@@@@@cccccccccccccccccc@@@@@                                            ██╔╝                       ║",
            @"║ccccccccccccccccccc@@@@@@cccccccccccccccccc@@@@                                            ╚═╝                        ║",
            @"║cccccccccccccccccccc@@@@@@cccccccccccccccccc@@                           ██████╗ ██╗  ██╗██╗   ██╗ ██████╗            ║",
            @"║ccccccccccccccccccccc@@@@@cccccccccccccc@@@@@@@@@@@@@@@@@@              ██╔═══██╗██║  ██║██║   ██║██╔═══██╗           ║",
            @"║cccccccccccccccccccccc@@@@@ccccccc@@@@@@ccccccccc@@@@@@@@@@             ██║      ███████║██║   ██║██║                 ║",
            @"║ccccccccccccccccccccccc@@@@cccc@@@ccccccccccccccccccc@@@@@@@            ██║   ██║██╔══██║██║   ██║██║   ██║           ║",
            @"║@@@@@@@cccccccccccccccc@@@@c@@@ccccccccccccccccccccccc@@@@@@@           ╚██████╔╝██║  ██║╚██████╔╝╚██████╔╝           ║",
            @"║       @@@cccccccccccccc@@@@ccccccccccccccccccccccccccc@@@@@@@           ╚═════╝ ╚═╝  ╚═╝ ╚═════╝  ╚═════╝            ║",
            @"║          @ccccccccccccc@@ccccccccccccccccccccccccccccccc@@@@@@                                                       ║",
            @"║          @cccccccccccc@@ccccccccccccccccccccccccccccccccc@@@@@                      ██╗                              ║",
            @"║          @cccccccccccc@cccccccccccccccccccccccccccccccccc@@@@@                      ╚██║                             ║",
            @"║       @@@@cccccccccccc@ccccccccccccccccccccccccccccccccccc@@@@                       ╚═╝                             ║",
            @"║    @@@@ccc            @ccccccccccc@@cccccccccccccccccccccc@@@                            ██╗                         ║",
            @"║ @@**                       cccccc@@  @@@cccccccccccccccccc@@           ███╗   ███╗██╗   ██╔╝███╗   ██╗ ██████╗       ║",
            @"║@**                           cc@@       @@@ccccccccccc@@@@             ████╗ ████║██║   ██║ ████╗  ██║██╔═══██╗      ║",
            @"║**                            c@            @@@@@@@@@@@                 ██╔████╔██║██║   ██║ ██╔██╗ ██║██║  ███║      ║",
            @"║*       @                    ***@                                       ██║╚██╔╝██║██║   ██║ ██║╚██╗██║██║   ██║      ║",
            @"║         @                    ***@                                      ██║ ╚═╝ ██║╚██████╔╝ ██║ ╚████║╚██████╔╝      ║",
            @"║     @@@@@             @@      ***@                                     ╚═╝     ╚═╝ ╚═════╝  ╚═╝  ╚═══╝ ╚═════╝       ║",
            @"║                     @@@@       **@                                                                                   ║",
            @"║             @      @@@@         **@                                    CHIẾN SĨ ĐÃ XUẤT SẮC VƯỢT QUA TRÒ CHƠI        ║",
            @"║                    @@            *@                                         ════  VÌ MỘT TRÁI ĐẤT XANH ════          ║",
            @"║                                   @          >> Nhấn F để xem lịch sử <<                                             ║",
            @"╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝",
            };


            // In ra từng dòng của chữ ASCII
            for (int i = 0; i < WinArt.Length; i++)
            {
                if (WinArt[i].Contains("c" + "@")) // Đặt màu xanh lá cho phần có chữ 'c' và '@'
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else // Đặt màu trắng cho phần còn lại
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(WinArt[i]);
            }
            // Reset lại màu
            Console.ResetColor();
        }
        public static void DrawFrame(string name)
        {
            int width = 62; // Chiều rộng khung
            int height = 4; // Chiều cao khung

            // Tạo mảng 2 chiều
            char[,] frame = new char[height, width];

            // Vẽ khung
            for (int i = 0; i < width; i++)
            {
                frame[0, i] = '═'; // Đường trên
                frame[height - 1, i] = '═'; // Đường dưới
            }

            // Các góc khung
            frame[0, 0] = '╔'; // Góc trên trái
            frame[0, width - 1] = '╗'; // Góc trên phải
            frame[height - 1, 0] = '╚'; // Góc dưới trái
            frame[height - 1, width - 1] = '╝'; // Góc dưới phải

            // Đặt tên vào giữa khung (trong dòng thứ 2)
            string displayName = $"               🌳🌳|| {name} ||🌳🌳";
            int nameStart = (width - displayName.Length) / 2;

            // Kiểm tra để tránh truy cập ngoài giới hạn mảng
            if (nameStart >= 0 && nameStart + displayName.Length <= width)
            {
                for (int i = 0; i < displayName.Length; i++)
                {
                    frame[1, nameStart + i] = displayName[i]; // Dòng thứ 2 chứa tên
                }
            }

            // In khung ra console
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(frame[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void Cloud()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int width = 120;
            int height = 6;
            string[,] frame = new string[height, width];

            // Cloud design
            string[] cloud = new string[]
            {
        "      ___   ",
        "   __(   )  ",
        "  (____)__) "
            };

            Random random = new Random();
            int cloudCount = 2; // Điều chỉnh số lượng mây bạn muốn

            // Đặt những đám mây ngẫu nhiên phía trên đường
            for (int i = 0; i < cloudCount; i++)
            {
                int cloudRow = random.Next(0, 4); // Sẽ vẽ ra bắt đầu từ dòng đầu tiên của mảng trong 4 hàng 
                int cloudStartCol = random.Next(0, width - cloud[0].Length); // Xuất hiện ở Cột ngẫu nhiên

                // Vòng lặp để in ra các đám mây
                for (int k = 0; k < cloud.Length; k++) // Lặp lại qua các đường mây (các hàng mây)
                {
                    for (int j = 0; j < cloud[k].Length; j++) // Lặp lại các ký tự trong mỗi dòng (các cột của đám mây)
                    {
                        frame[cloudRow + k, cloudStartCol + j] = cloud[k][j].ToString(); // Vì cộng thêm độ dài của mảng là 3 nên trên màn hình console đám mây xuất hiện ngẫu nhiên tổng cộng là 7 hàng 
                    }
                }

            }
            // In khung ra console
            Console.SetCursorPosition(0, 5); 
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(frame[i, j] ?? " "); // In các khoảng trắng để đảm bảo hình đám mây không trùng lên nhau 
                }
                Console.WriteLine(); 
            }

            Console.ResetColor();
        }
        public static void Road()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int width = 120;
            int height = 2;
            string[,] frame = new string[height, width];

            // Set the bottom border
            for (int i = 0; i < width; i++)
            {
                frame[height - 1, i] = "=";
            }

            Console.SetCursorPosition(0, 16);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(frame[i, j]);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        public static void esc()
        {
            Console.SetCursorPosition(108, 26);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Ecs để thoát");
            Console.ResetColor();
        }
        public void DisplayLeaderboard()
        {
            string filePath = "UEHer.txt";
            Console.CursorVisible = false;
            int consoleWidth = 120;
            int consoleHeight = 27;
            int linesPerPage = consoleHeight - 5; // Trừ đi 5 dòng dành cho tiêu đề và chân trang

            // Thiết lập kích thước console
            Console.SetWindowSize(consoleWidth, consoleHeight);           

            while (true) // Vòng lặp cho đến khi người dùng chọn thoát
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.F) // Nhấn phím F để hiển thị bảng xếp hạng
                {
                    if (!File.Exists(filePath))
                    {
                        Console.Clear();
                        Console.WriteLine("Chưa có người chơi nào."); // Chưa có người chơi nào

                        continue; // Tiếp tục chờ đầu vào
                    }

                    Console.Clear();
                    // Định nghĩa các dòng khung trong mảng
                    string[] boxLines = new string[]
                    {
                "╔════════════════════════════════════════╗",
                "║ LỊCH SỬ CHINH PHỤC UEH GREEN CỦA UEHer ║",
                "╚════════════════════════════════════════╝"
                    };
                    // Tính toán vị trí bắt đầu để in khung
                    int startPositionX = consoleWidth / 4; // Vị trí X bắt đầu
                    int startPositionY = 0; // Vị trí Y bắt đầu

                    // In từng dòng của khung
                    for (int i = 0; i < boxLines.Length; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(startPositionX, startPositionY + i); // Đặt vị trí con trỏ
                        Console.WriteLine(boxLines[i]); // In dòng
                        Console.ResetColor();
                    }

                    // Đọc nội dung từ file
                    string[] lines = File.ReadAllLines(filePath);
                    int totalPages = (int)Math.Ceiling((double)lines.Length / linesPerPage);
                    int currentPage = 1;

                    while (true)
                    {
                        Console.Clear();

                        // In lại khung
                        for (int i = 0; i < boxLines.Length; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(startPositionX, startPositionY + i);
                            Console.WriteLine(boxLines[i]);
                            Console.ResetColor();
                        }

                        // Tính toán dòng bắt đầu và kết thúc cho trang hiện tại
                        int startLine = (currentPage - 1) * linesPerPage;
                        int endLine = Math.Min(startLine + linesPerPage, lines.Length);

                        // In trang hiện tại của bảng xếp hạng
                        for (int i = startLine; i < endLine; i++)
                        {
                            Console.SetCursorPosition(0, startPositionY + boxLines.Length + (i - startLine));
                            Console.WriteLine(lines[i]);
                        }

                        // Chân trang: Hiển thị hướng dẫn điều hướng trang
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(0, consoleHeight - 2);
                        Console.WriteLine($"Trang {currentPage}/{totalPages} - Nhấn ← hoặc → để chuyển trang, Enter 2 lần để thoát.");
                        Console.ResetColor();

                        // Chờ người dùng nhập để điều hướng hoặc thoát
                        key = Console.ReadKey(true).Key;
                        if (key == ConsoleKey.RightArrow && currentPage < totalPages)
                        {
                            currentPage++;
                        }
                        else if (key == ConsoleKey.LeftArrow && currentPage > 1)
                        {
                            currentPage--;
                        }
                        else if (key == ConsoleKey.Enter)
                        {
                            break; // Thoát hiển thị bảng xếp hạng
                        }
                    }
                }
                else if (key == ConsoleKey.Enter) // Thoát chương trình
                {
                    break;
                }
            }
        }
    }
}
