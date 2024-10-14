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
            Console.ForegroundColor = ConsoleColor.Green;
            string[] introArt = new string[]
            {
            @"╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗",
            @"║                                                                                                                      ║",
            @"║                                                    @@@@@    @@                               @@@@   @                ║",
            @"║                                                  @@@   @@@ @@                               @   @@@@                 ║",
            @"║                                                                                                                      ║",
            @"║                  @@@@@@@     @@@     @@@   @@@   @@@@@@@@@   @@@@    @@@          @@@@@@@@@    @@@                   ║",
            @"║                 @@@@@@@@@    @@@     @@@   @@@   @@@         @@@@@   @@@         @@@@@@@@@@@   @@@                   ║",
            @"║                @@@@      @   @@@     @@@   @@@   @@@         @@@@@@  @@@          @@@@    @@   @@@                   ║",
            @"║                @@@@          @@@@@@@@@@@   @@@   @@@@@@@@@   @@@ @@@ @@@             @@@       @@@                   ║",
            @"║                @@@@      @   @@@     @@@   @@@   @@@         @@@  @@@@@@         @@    @@@@    @@@                   ║",
            @"║                 @@@@@@@@@    @@@     @@@   @@@   @@@         @@@   @@@@@         @@@@@@@@@@@   @@@                   ║",
            @"║                  @@@@@@@     @@@     @@@   @@@   @@@@@@@@@   @@@    @@@@          @@@@@@@@@    @@@                   ║",
            @"║                                                                                                                      ║",
            @"║            @@@     @@@     @@@@@@@     @@@@    @@@   @@@     @@@                          ccc@@\                     ║",
            @"║            @@@     @@@    @@@@@@@@@    @@@@@   @@@   @@@     @@@                c@@@@@@\ /ccc@@@|                    ║",
            @"║             @@@   @@@    @@@     @@@   @@@@@@  @@@   @@@     @@@               /ccc@@@@@\@ccc@@/ccc\                 ║",
            @"║               @@@@@      @@@@@@@@@@@   @@@ @@@ @@@   @@@@@@@@@@@               cccccccc@@\@@@/cccc@@                 ║",
            @"║             @@@   @@@    @@@     @@@   @@@  @@@@@@   @@@     @@@                \ccccccc@|cccccc@@@/                 ║",
            @"║            @@@     @@@   @@@     @@@   @@@   @@@@@   @@@     @@@                   \ccccc@ccc@@@/                    ║",
            @"║            @@@     @@@   @@@     @@@   @@@    @@@@   @@@     @@@                   |           |                     ║",
            @"║                                                                                   /*  >     <  *\                    ║",
            @"║                                             ╔════════════════════════╗           |****   0   ****|                   ║",
            @"║                                             ║      >>> Enter <<<     ║           |***************|                   ║",
            @"║                                             ╚════════════════════════╝                                               ║",
            @"║                                                                                                                      ║",
            @"║                                                                                                                      ║",
            @"╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝"
            };

            foreach (string line in introArt)
            {
                Console.WriteLine(line);
            }
            Console.ResetColor();
        }
        public static void PrintEnterNFBanner(string[] banner)
        {
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
                if (banner[i].Contains("╔" + "═" + "╚" + "║" + "╝")) // Đặt màu xanh lá cho phần có chữ 'c'
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                }

                else // Đặt màu trắng cho phần còn lại
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
            }
            Console.ResetColor();
        }

        public static void printUEHBuilding1()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string[] truong1 = new string[]
                {
            "Nhấn Enter để tiếp tục...                                                                                               " + '\n' +
            "                                                                                                                        " + '\n' +
            "                                                                                                                        " + '\n' +
            "                                                  GÓC GIỚI THIỆU VỀ UEH                                                 " + '\n' +
            "                                                                                                                        " + '\n' +
            "                                                                                                                        " + '\n' +
            " ____________________________________________________________________                                                   " + '\n' +
            "|          ║║ | | | | | | | | | | | | | |║║   ||  ||||  ||||  ||||   |     ____________________________________________ " + '\n' +
            "|__________║║ | | | | | | | | | | | | | |║║   ||  ||||  ||||  ||||   |    | Đây chính là trụ sở chính của UEH          |" + '\n' +
            "|   UEH    ║║_|_|_|_|_|_|_|_|_|_|_|_|_|_|║║═══||══||||══||||══||||═══|    |                                            |" + '\n' +
            "|university║║ | | | | | | | | | | | | | |║║   ||  ||||  ||||  ||||   |    | Là cơ sở lâu đời mang giá trị truyền thống |" + '\n' +
            "|__________║║ | | | | | | | | | | | | | |║║═══||══||||══||||══||||═══|    |   lịch sử, văn hóa, gắn bó với nhiều thế hệ|" + '\n' +
            "|          ║╚════════════════════════════╝║   ||  ||||  ||||  ||||   |    |   Thầy/Cô và người học.                    |" + '\n' +
            "|          ║  ║  ║  ║  ║  ║  ║  ║  ║  ║   ║___||__||||__||||__||||___|    |                                            |" + '\n' +
            "|          ║  ║  ║  ║  ║  ║  ║__║__║__║___║   ║   ║   ║   ║   ║   ║  |    | Là địa điểm quen thuộc khi sinh viên có vấn|" + '\n' +
            "|          ║  ║  ║  ║  ║  ║  ║  ║  ║  ║   ║   ║   ║   ║   ║   ║   ║  |    |    đề, thủ tục liên quan đến hồ sơ giấy tờ |" + '\n' +
            "|__________║__║__║__║__║__║__║  ║  ║  ║   ║___║___║___║___║___║___║__|    |    như cấp giấy chứng nhận sinh viên,...   |" + '\n' +
            "                                                                           -------------------------------------------  " + '\n' +
            "                          << CỞ SỞ A >>                                                                                 "
                };
            foreach (var line in truong1)
            {
                Console.WriteLine(line);
            }
            Console.ResetColor ();
        }
        public static void printUEHBuilding2()
        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            string[] truong2 = new string[]
                {
            "Nhấn Enter để tiếp tục...                                                                                            " + '\n' +
            "                                                                                                                     " + '\n' +
            "                                                  GÓC GIỚI THIỆU VỀ UEH                                              " + '\n' +
            "                                                                                                                     " + '\n' +
            "                      _________________                                                                              " + '\n' +
            "                     |___║___║___║__|__|                                                                             " + '\n' +
            "                     |___║___║___║__|__|                                                                             " + '\n' +
            "                     |═══║═══║═══║__|__|                                                                             " + '\n' +
            "                     |═══║═══║═══║__|__|                   _________________________________________________________ " + '\n' +
            "                     |═══║═══║═══║__|__|                  | Được mệnh danh là Cơ sở thông minh, đánh dấu bước ngoặt |" + '\n' +
            "                     |═══║═══║═══║__|__|                  |   về đổi mới cơ sởvật chất theo hướng chuẩn đại học quốc|" + '\n' +
            "                     |═══║═══║═══║__|__|                  |   tế của UEH.                                           |" + '\n' +
            "                     |═══║═══║═══║__|__|                  |                                                         |" + '\n' +
            "                     |═══║═══║═══║__|__|                  | Được xem là trung tâm của mọi hoạt động động học tập,   |" + '\n' +
            "                     |═══║═══║═══║══|══|                  |   là nơi đặt văn phòng của các khoa để các bạn sinh viên|" + '\n' +
            "                     |_ĐẠI HỌC KINH TẾ_|                  |   có thể dễ dàng được giải đáp thắc mắc và hướng dẫn các|" + '\n' +
            "                     |===║===║===║__║__|                  |   vấn đề liên đến học thuật.                            |" + '\n' +
            "                     |   ║   ║   ║__║__|                   --------------------------------------------------------- " + '\n' +
            "                     |___║___║___║__║__|                                                                             " + '\n' +
            "                     |   ║   ║   ║  ║  |                                                                             " + '\n' +
            "                     |___║___║___║__║__|                                                                             " + '\n' +
            "                                                                                                                     " + '\n' +
            "                        << CỞ SỞ B >>                                                                                "

                };
            foreach (var line in truong2)
            {
                Console.WriteLine(line);
            }
            Console.ResetColor();
        }
        public static void printUEHBuilding3()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string[] truong3 = new string[]
                {
             "Nhấn Enter để tiếp tục...                                                                                            " + '\n' +
             "                                                                                                                     " + '\n' +
             "                                                  GÓC GIỚI THIỆU VỀ UEH                                              " + '\n' +
             "                                                                                                                     " + '\n' +
             "                           __________      " + '\n' +
             "                          |  UEH     |     " + '\n' +
             "                     _____|____════════╗   " + '\n' +
             "                     ||   W   |║       ║   " + '\n' +
             "                     ||western|║       ║   " + '\n' +
             "                     || sydney|║       ║   " + '\n' +
             "                     |█████████║███████║   " + '\n' +
             "                     | █ █ █ █ ║       ║   " + '\n' +
             "                     | █ █ █ █ ║       ║   " + '\n' +
             "                     |█████████║███████║   " + '\n' +
             "                     | |     | ║       ║   " + '\n' +
             "                     | | ISB | ║       ║   " + '\n' +
             "                     |▄|▄▄▄▄▄|▄▄▄▄▄▄▄▄▄|   " + '\n' +
             "                     |--------|    |   |   " + '\n' +
             "                     |--------|    |   |   " + '\n' +
             "                     |________|____|___|   " + '\n' +
             "                                                                                                                     " + '\n' +
             "                       << CỞ SỞ I >>                                                                                "

                };
            foreach (var line in truong3)
            {
                Console.WriteLine(line);
            }
            Console.ResetColor();
        }
        public static void printUEHBuilding4()
        {
            
            string[] truong4 = new string[]
                {
                 "      ____________________ " + '\n' +
                 "     |        ║     ║_____|" + '\n' +
                 "     |   _____║     ║||||||" + '\n' +
                 "     |___|||||║     ║═════|" + '\n' +
                 "     |        ║     ║_____|" + '\n' +
                 "     |   _____║ UEH ║||||||" + '\n' +
                 "     |___|||||║.....║═════|" + '\n' +
                 "     |        ║.....║_____|" + '\n' +
                 "     |   _____║     ║||||||" + '\n' +
                 "     |___|||||║     ║═════|" + '\n' +
                 "     |   _____║     ║_____|" + '\n' +
                 "     |   |||||║     ║||||||" + '\n' +
                 "     |========╚═════╝═════|" + '\n' +
                 "     |     ║  |           |" + '\n' +
                 "     |     ║  |           |" + '\n' +
                 "     |_____║__|___________|   ",
                 };
            foreach (var line in truong4)
            {
                Console.WriteLine(line);
            }
        }
        public static void printUEHBuilding5()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string[] truong5 = new string[]
                {
                     "                    ________                   " + '\n' +
                     "      ______________║ ║   ║ ║______________    " + '\n' +
                     "     |              ║ ║   ║ ║              |   " + '\n' +
                     "     |              ║ ║   ║ ║              |   " + '\n' +
                     "     |           ___║ ║ U ║ ║___           |   " + '\n' +
                     "     |          ║   ║ ║ E ║ ║   ║          |   " + '\n' +
                     "     |       ___║   ║ ║ H ║ ║   ║___       |   " + '\n' +
                     "     |      ║   ║   ║ ║   ║ ║   ║   ║      |   " + '\n' +
                     "     |      ║   ║   ║ ║   ║ ║   ║   ║      |   " + '\n' +
                     "     |      ║   ║   ║ ║   ║ ║   ║   ║      |   " + '\n' +
                     "     |   ___║   ║   ║ ╚═══╝ ║   ║   ║___   |   " + '\n' +
                     "     |  ║   ║   ║   ║  _ _  ║   ║   ║   ║  |   " + '\n' +
                     "     |  ║   ║   ║   ║ | | | ║   ║   ║   ║  |   " + '\n' +
                     "     |__║___║___║___║_|_|_|_║___║___║___║__|   ",

                 };
            foreach (var line in truong5)
            {
                Console.WriteLine(line);
            }
            Console.ResetColor();
        }
        public static string[] Bangmota(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string[] bangmota = new string[]
            {
                @"                              HÀNH TRÌNH TRỞ THÀNH CHIẾN SĨ XANH                                    ",
                @"  |━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━|  ",
                @"  |Bộ câu hỏi 1:   Chiến thắng khi bạn trả lời đúng 10 câu hỏi về phân loại rác                  |  ",
                @"  |Bộ câu hỏi 2:   Chiến thắng khi bạn trả lời đúng 10 câu hỏi về UEH Green                      |  ",
                @"  |                                                                                              |  ",
                @"  |Luật chơi: Bạn được phép trả lời sai 2 câu. Sai 3 câu trò chơi sẽ kết thúc                    |  ",
                @"  |           Lưu lại bút danh (tối đa 22 kí tự, không vượt qua khung)                           |  ",
                @"  |                                               để ghi nhận thành quả hoàn thành Chiến Sĩ Xanh |  ",
                @"  |                                                                                              |  ",
                @"  |Xếp loại: CS1(0-4): Tìm hiểu thêm nhé!                                *********************   |  ",
                @"  |          CS2(5-9): Cố gắng vào lần sau!                              * Hoàn thành 20 câu *   |  ",
                @"  |          CS3(10-14): Bạn đã có kiến thức cơ bản về UEH Green rồi!    *     Bạn là CSX    *   |  ",
                @"  |          CS4(15-19): Bạn đã tiến gần đến danh hiệu Chiến Sĩ Xanh!    *********************   |  ",
                @"  |━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━|  ",
            };
            for (int i = 0; i < bangmota.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(bangmota[i]);
            }
            Console.ResetColor();
            return bangmota;
        }
        public static void TinhDiem(int score)
        {

            // Hiển thị điểm
            Console.SetCursorPosition(2, 2); // Đặt vị trí con trỏ cho điểm
            for (int i = 0; i < score; i++)
            {
                Console.Write("🌳 ");
            }

            Thread.Sleep(1000); // Tạm dừng một giây
        }
        public static void DrawHealthBar(int health, int maxHealth)
        {
            // Each health icon takes up 2 characters (icon + space), plus an additional space for the borders
            int barWidth = maxHealth * 2 + 4; // Calculate the width of the health bar including the frame

            // Draw top border
            Console.SetCursorPosition(108, 0);
            Console.Write("╔");
            for (int i = 0; i < barWidth; i++) Console.Write("═");
            Console.WriteLine("╗");

            // Draw health bar with side borders
            Console.SetCursorPosition(108, 1);
            Console.Write("║ "); // Left border
            for (int i = 0; i < maxHealth; i++)
            {
                if (i < health)
                {
                    Console.Write("❤️ "); // Display health
                }
                else
                {
                    Console.Write("🗑️ "); // Display lost health
                }
            }
            Console.Write("║"); // Right border
            Console.WriteLine();

            // Draw bottom border
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
            @"     ╔════════════════════════════════╗     ",
            @"     ║                                ║     ",
            @"     ║   >>Nhấn F để xem lịch sử<<    ║     ",
            @"     ║                                ║     ",
            @"     ╚════════════════════════════════╝     ",
            };

            // Đặt con trỏ tại vị trí(x, y)
            for (int i = 0; i < art.Length; i++)
            {
                if (art[i].Contains("c" + "@")) // Đặt màu xanh lá cho phần có chữ 'c'
                {
                    Console.ForegroundColor = ConsoleColor.Green;
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
        public static string InputPlayerName()
        {
            // Bảng điền tên 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(Console.WindowWidth / 3, 17);
            Console.WriteLine("CHÀO MỪNG BẠN ĐẾN VỚI CHIẾN SĨ XANH!");
            string YourName = "";
            bool validInput = false;

            // Kích thước khung (tăng chiều rộng)
            int frameWidth = 40;  // Kéo dài khung ra
            int frameX = Console.WindowWidth / 3 - 5;  // Dịch khung sang trái
            int frameY = 17 + 1;

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
                Console.SetCursorPosition(frameX + 12, frameY + 1);  // Đặt con trỏ ngay sau phần "BÚT DANH :"

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
    }
}
