using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using UEH_Green;
using System.Data.SqlClient;
using System.Net;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Schema;

namespace UEHGreen
{
    internal class Program
    {
        static List<UehQuestion> questions = new List<UehQuestion>()
        {
        new UehQuestion(
            "Giấy nên được phân loại vào thùng nào theo mô hình 3 thùng?",
            new string[] { "A) Thùng rác hữu cơ", "B) Thùng rác tái chế", "C) Thùng rác không tái chế", "D) Thùng rác thực phẩm" }, "B"),
        new UehQuestion(
            "Rác thải thực phẩm được phân vào thùng nào trong mô hình 3 thùng?",
            new string[] { "A) Thùng rác hữu cơ", "B) Thùng rác tái chế", "C) Thùng rác không tái chế", "D) Thùng rác điện tử" }, "A"),
        new UehQuestion(
            "Những loại rác không thể tái chế, như băng keo hoặc nhựa dẻo, được bỏ vào thùng nào?",
            new string[] { "A) Thùng rác hữu cơ", "B) Thùng rác tái chế", "C) Thùng rác không tái chế", "D) Thùng rác kim loại" }, "C"),
        new UehQuestion(
            "Chai nhựa hoặc lon nước có thể phân loại vào thùng nào?",
            new string[] { "A) Thùng rác hữu cơ", "B) Thùng rác tái chế", "C) Thùng rác không tái chế", "D) Thùng rác điện tử" }, "B"),
        new UehQuestion(
            "Rác thải điện tử như pin hay đồ điện tử nhỏ được bỏ vào thùng nào theo mô hình 7 thùng?",
            new string[] { "A) Thùng rác giấy", "B) Thùng rác kim loại", "C) Thùng rác điện tử", "D) Thùng rác thực phẩm" }, "C"),
        new UehQuestion(
            "Chất thải thực phẩm nên được phân vào thùng nào trong mô hình 7 thùng?",
            new string[] { "A) Thùng rác hữu cơ", "B) Thùng rác giấy", "C) Thùng rác không tái chế", "D) Thùng rác thực phẩm" }, "D"),
        new UehQuestion(
            "Lon nước bằng kim loại thuộc vào thùng nào trong mô hình 7 thùng?",
            new string[] { "A) Thùng rác giấy", "B) Thùng rác kim loại", "C) Thùng rác nhựa", "D) Thùng rác thực phẩm" }, "B"),
        new UehQuestion(
            "Túi ni lông nên được phân vào thùng nào trong mô hình 7 thùng?",
            new string[] { "A) Thùng rác nhựa", "B) Thùng rác thực phẩm", "C) Thùng rác hữu cơ", "D) Thùng rác không tái chế" }, "A"),
        new UehQuestion(
            "Những loại rác nào nên được phân vào thùng rác giấy trong mô hình 7 thùng?",
            new string[] { "A) Giấy viết, sách vở cũ", "B) Hộp sữa giấy", "C) Túi ni lông", "D) Đồ ăn thừa" }, "A"),
        new UehQuestion(
            "Thức ăn thừa thuộc vào thùng nào trong mô hình 7 thùng?",
            new string[] { "A) Thùng rác thực phẩm", "B) Thùng rác hữu cơ", "C) Thùng rác nhựa", "D) Thùng rác giấy" }, "A"),
        new UehQuestion(
            "Giấy gói quà thuộc vào thùng nào theo mô hình 7 thùng?",
            new string[] { "A) Thùng rác giấy", "B) Thùng rác nhựa", "C) Thùng rác không tái chế", "D) Thùng rác hữu cơ" }, "A"),
        new UehQuestion(
            "Các sản phẩm bằng thủy tinh nên được phân loại vào thùng nào trong mô hình 7 thùng?",
            new string[] { "A) Thùng rác thực phẩm", "B) Thùng rác thủy tinh", "C) Thùng rác nhựa", "D) Thùng rác giấy" }, "B"),
        new UehQuestion(
            "Hộp sữa bằng giấy (Tetra Pak) nên phân vào thùng nào trong mô hình 7 thùng?",
            new string[] { "A) Thùng rác giấy", "B) Thùng rác nhựa", "C) Thùng rác không tái chế", "D) Thùng rác hữu cơ" }, "A"),
        new UehQuestion(
            "Các sản phẩm nhựa mềm như màng bọc thực phẩm được phân vào thùng nào?",
            new string[] { "A) Thùng rác nhựa", "B) Thùng rác giấy", "C) Thùng rác hữu cơ", "D) Thùng rác không tái chế" }, "A"),
        new UehQuestion(
            "Thức ăn thừa và vỏ trái cây nên được phân loại vào thùng nào trong mô hình 7 thùng?",
            new string[] { "A) Thùng rác thực phẩm", "B) Thùng rác giấy", "C) Thùng rác nhựa", "D) Thùng rác kim loại" }, "A")
        };

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // Giao diện bắt đầu
            Console.CursorVisible = false;
            GiaoDien intro = new GiaoDien();
            intro.DisplayIntro();

            // Wait for user input to continue
            Console.ReadLine();
            Console.Clear();

            //Giao diện giới thiệu game  
            string[] myArray = Bangmota(10, 1);
            //Bảng điền tên 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(Console.WindowWidth / 3, Console.WindowHeight / 2);
            Console.WriteLine("CHÀO MỪNG BẠN ĐẾN VỚI CHIẾN SĨ XANH!");
            string YourName = "";
            bool validInput = false;

            // Kích thước khung (tăng chiều rộng)
            int frameWidth = 40;  // Kéo dài khung ra
            int frameX = Console.WindowWidth / 3 - 5;  // Dịch khung sang trái
            int frameY = Console.WindowHeight / 2 + 1;

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
            Console.ResetColor();
            Console.Clear();
            string[] banner = new string[]
{
            @"╔════════════════════════════╗                          ╔═══════════════════════════════╗",
            @"║                            ║                          ║                               ║",
            @"║  >>Nhấn ENTER để CHƠI<<    ║                          ║   >>Nhấn F để XEM LỊCH SỬ<<   ║",
            @"║                            ║                          ║                               ║",
            @"╚════════════════════════════╝                          ╚═══════════════════════════════╝",

};
            Console.ForegroundColor = ConsoleColor.Green;
            GiaoDien.PrintEnterNFBanner(banner);
            Console.ResetColor();
            DisplayLeaderboard();

            string[] runningAnimation =
                {
	#region Frames
	// 0
	@"       " + '\n' +
    @"   UEH " + '\n' +
    @"  __O  " + '\n' +
    @" / /\_," + '\n' +
    @"__/\   " + '\n' +
    @"    \  ",
	// 1
	@"       " + '\n' +
    @"   UEH  " + '\n' +
    @"   _O  " + '\n' +
    @"  |/|_ " + '\n' +
    @"  /\   " + '\n' +
    @" /  |  ",
	// 2
	@"       " + '\n' +
    @"   UEH " + '\n' +
    @"    O  " + '\n' +
    @"  </L  " + '\n' +
    @"   \   " + '\n' +
    @"   /|  ",
	// 3
	@"       " + '\n' +
    @"   UEH " + '\n' +
    @"   O   " + '\n' +
    @"   |_  " + '\n' +
    @"   |>  " + '\n' +
    @"  /|   ",
	// 4
	@"       " + '\n' +
    @"   UEH " + '\n' +
    @"   O   " + '\n' +
    @"  <|L  " + '\n' +
    @"   |_  " + '\n' +
    @"   |/  ",
	// 5
	@"       " + '\n' +
    @"   UEH " + '\n' +
    @"   O   " + '\n' +
    @"  L|L  " + '\n' +
    @"   |_  " + '\n' +
    @"  /  | ",
	// 6
	@"       " + '\n' +
    @"   UEH " + '\n' +
    @"  _O   " + '\n' +
    @" | |L  " + '\n' +
    @"   /-- " + '\n' +
    @"  /   |",
                #endregion
            };


            string[] jumpingAnimation =
            {
                #region Frames
                // 0
    @"       " + '\n' +
    @"       " + '\n' +
    @"   _O  " + '\n' +
    @"  |/|_ " + '\n' +
    @"  /\   " + '\n' +
    @" /  |  ",
	// 1
	@"       " + '\n' +
    @"       " + '\n' +
    @"       " + '\n' +
    @"    O  " + '\n' +
    @"  </L  " + '\n' +
    @"   /|  ",
	// 2
	@"       " + '\n' +
    @"    /O/" + '\n' +
    @"    /  " + '\n' +
    @"   //  " + '\n' +
    @"  //   " + '\n' +
    @"       ",
	// 3
	@"  O" + '\n' +
    @" /     " + '\n' +
    @"//     " + '\n' +
    @"       " + '\n' +
    @"       " + '\n' +
    @"       ",
	// 4
	@"  __   " + '\n' +
    @" // \O " + '\n' +
    @"     \\" + '\n' +
    @"       " + '\n' +
    @"       " + '\n' +
    @"       ",
	// 5
	@"  __   " + '\n' +
    @" //_O\ " + '\n' +
    @"       " + '\n' +
    @"       " + '\n' +
    @"       " + '\n' +
    @"       ",
	// 6
	@"  __\  " + '\n' +
    @" _O/   " + '\n' +
    @"       " + '\n' +
    @"       " + '\n' +
    @"       " + '\n' +
    @"       ",
	// 7
	@" \O\__ " + '\n' +
    @"     \\" + '\n' +
    @"       " + '\n' +
    @"       " + '\n' +
    @"       ",
	// 8
	@"       " + '\n' +
    @"       " + '\n' +
    @"   O   " + '\n' +
    @"  L|L  " + '\n' +
    @"   |_  " + '\n' +
    @"  /  | ",
                #endregion
            };
            string hurdleFrame =
            #region Frame


              @"   BIN   " + '\n' +
              @"  ____  " + '\n' +
              @"  ║♻️║ " + '\n' +
              @"  \__/   ";
            #endregion
            int position = 0;
            int? runningFrame = 0;
            int? jumpingFrame = null;
            int hurdlePosition = 50;
            bool isStopped = false;
            const int stopDistance = 10; // Khoảng cách dừng lại trước vật cản


            Console.CursorVisible = false;
            try
            {
                if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                {
                    int maxWidth = 120;
                    int maxHeight = 27;

                    Console.SetWindowSize(
                        Math.Min(Console.LargestWindowWidth, maxWidth),
                        Math.Min(Console.LargestWindowHeight, maxHeight));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Không thể thay đổi kích thước cửa sổ console: " + ex.Message);
            }
            Console.Clear();

            // Shuffle the list using Fisher-Yates algorithm
            Shuffle(questions);
            int score = 0;
            int wrongAnswers = 0;

            int health = 3; // Số lượng cục máu tối đa
            const int MaxHealth = 3;
            Console.CursorVisible = false;


            while (true)
            {
                Console.SetCursorPosition(0, 0);
                // Vẽ khung
                Console.WriteLine("╔════════════════════════════════╗");
                Console.WriteLine($"   🌳||{YourName}||🌳                ");
                Console.WriteLine("║                                ║");
                Console.WriteLine("╚════════════════════════════════╝");

                DrawHealthBar(health, MaxHealth);
                string playerFrame =
                    jumpingFrame.HasValue ? jumpingAnimation[jumpingFrame.Value] :
                    runningAnimation[runningFrame.GetValueOrDefault()];

                //Kiểm tra phím nhấn 
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.Write("TRÒ CHƠI KẾT THÚC!");
                        Console.ReadKey();
                        return;
                    }
                }

                //Dừng lại trước vật cản 
                if (position >= hurdlePosition - stopDistance && position < hurdlePosition)
                {
                    runningFrame = 7;
                    isStopped = true;
                    position = hurdlePosition - stopDistance;

                    // Lượt qua các câu hỏi  

                    foreach (var question in questions.ToList())
                    {
                        if (wrongAnswers == 3)//thua trò chơi
                        {
                            Console.Clear();
                            SaveAchievement(YourName, score);
                            SaveGameRanking(YourName, score);
                            DisplayLeaderboard();
                            Console.ReadKey();
                            return; // Exit the game
                        }

                        //Hiển thị câu hỏi và đáp án ở phía dưới màn hình
                        PositionAtBottom();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nQuestion: " + question.Question);

                        Console.ResetColor();
                        foreach (var choice in question.Choices)
                        {

                            Console.WriteLine(choice);
                        }

                        int questionCursorTop = Console.CursorTop - (question.Choices.Length + 1);

                        string userAnswer = "";
                        bool isValidAnswer = false; // Flag for valid input

                        while (!isValidAnswer) // Tiếp tục ấn cho tới khi người chơi nhập đúng
                        {
                            try
                            {
                                // Ask the player to input their answer
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Điền A, B, C, hoặc D để trả lời: ");
                                Console.ResetColor();
                                // Nhận nút của người chơi
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                userAnswer = Console.ReadKey().KeyChar.ToString().ToUpper();

                                Console.ResetColor();
                                // Kiểm tra nút bấm
                                if (!new[] { "A", "B", "C", "D" }.Contains(userAnswer))
                                {
                                    // Nhập sai, tạo ra ngoại lệ
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    throw new InvalidOperationException("Phím không hợp lệ. Vui lòng nhập A, B, C, hoặc D.");

                                }

                                // Nhập đúng, thoát ra để tiếp tục mạch game
                                isValidAnswer = true;
                            }
                            catch (InvalidOperationException ex)
                            {
                                // Xử lý ngoại lệ khi nhập sai
                                Console.WriteLine($"\n{ex.Message}");

                                // Di chuyển trỏ chuột để tránh cấn dòng khi nhập sai
                                Console.SetCursorPosition(0, Console.CursorTop - 2);
                            }
                        }

                        ClearQuestionAndAnswer(questionCursorTop, question.Choices.Length + 1);  // Xóa toàn bộ màn hình
                        //Xử lí đáp án 
                        if (userAnswer == question.CorrectAnswer)
                        {
                            score++;
                            TinhDiem(score);
                            jumpingFrame = 0;
                            runningFrame = null;
                            isStopped = false;
                            position = hurdlePosition + 1;
                            hurdlePosition += 50;

                            questions.Remove(question);
                            Console.Clear();

                        }

                        else
                        {
                            // Clear the previous question and answer text without clearing the whole screen
                            ClearQuestionAndAnswer(questionCursorTop, question.Choices.Length + 1); // Adjust +1 for the question
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();

                            wrongAnswers++;
                            health--;

                            questions.Remove(question);
                        }
                        ClearQuestionAndAnswer(questionCursorTop, question.Choices.Length + 1);

                        break;
                    }
                    // Chiến thắng trò chơi
                    if (score == 1)
                    {
                        Console.Clear();
                        PrintArt(Console.WindowWidth / 3, Console.WindowHeight / 7);
                        SaveAchievement(YourName, score);
                        DisplayLeaderboard();
                        Console.ReadKey();
			Console.Clear();// Xóa màn hình ván cũ và lịch sử
                        continue; // Exit the game
                    }
                }
                else
                {
                    isStopped = false;
                }

                // Xác định khung hình 
                Console.SetCursorPosition(4, 8);
                Render(playerFrame, true);
                RenderHurdles(true);


                if (position % 50 < 3)
                {
                    Console.SetCursorPosition(4, 8);
                    Render(playerFrame, false);
                    RenderHurdles(false);
                }
                else
                {
                    RenderHurdles(false);
                    Console.SetCursorPosition(4, 8);
                    Render(playerFrame, false);
                }

                // Cập nhật trạng thái 
                runningFrame = runningFrame.HasValue
                    ? (runningFrame + 1) % runningAnimation.Length
                    : runningFrame;

                jumpingFrame = jumpingFrame.HasValue
                    ? jumpingFrame + 1
                    : jumpingFrame;

                if (jumpingFrame >= jumpingAnimation.Length)
                {
                    jumpingFrame = null;
                    runningFrame = 2;
                }

                // Move the character if not stopped
                if (!isStopped)
                {
                    position++;
                }
                Thread.Sleep(TimeSpan.FromMilliseconds(80));
            }
            void Render(string @string, bool renderEnter)
            {
                int x = Console.CursorLeft;
                int y = Console.CursorTop;
                foreach (char c in @string)
                    if (c == '\n')
                        Console.SetCursorPosition(x, ++y);
                    else if (c != ' ' || renderEnter)
                        Console.Write(c);
                    else
                        Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
            }
            void RenderHurdles(bool renderEnter)
            {
                // Xóa các vị trí cũ của vật cản trên màn hình
                Console.SetCursorPosition(0, 10);
                Console.Write(new string(' ', Console.WindowWidth));

                // Vẽ vật cản ở các vị trí hiện tại
                if (position + 50 >= hurdlePosition && position <= hurdlePosition + 10)
                {
                    int hurdleOffset = hurdlePosition - position;
                    // Đảm bảo hurdleOffset không âm và không vượt quá kích thước của cửa sổ
                    hurdleOffset = Math.Max(0, Math.Min(Console.WindowWidth - hurdleFrame.Length, hurdleOffset));
                    Console.SetCursorPosition(hurdleOffset, 10);
                    Render(hurdleFrame, renderEnter);

                }
            }
        }
        static void TinhDiem(int score)
        {

            // Hiển thị điểm
            Console.SetCursorPosition(2, 2); // Đặt vị trí con trỏ cho điểm
            for (int i = 0; i < score; i++)
            {
                Console.Write("🌳 ");
            }

            Thread.Sleep(1000); // Tạm dừng một giây
        }
        static void DrawHealthBar(int health, int maxHealth)
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
        static void PrintArt(int x, int y)
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
           @" ╔═══════════════════════════════════════════╗     ",
           @" ║                                           ║     ",
           @" ║   >>Nhấn F để xem lịch sử và tiếp tục<<   ║     ",
           @" ║                                           ║     ",
           @" ╚═══════════════════════════════════════════╝     ",
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
        static string[] Bangmota(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string[] bangmota = new string[]
            {
                @"                              HÌNH TRÌNH TRỞ THÀNH CHIẾN SĨ XANH                                    ",
                @"  |━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━|  ",
                @"  |Round 1:   Chiến thắng khi bạn trả lời đúng 10 câu hỏi về phân loại rác                       |  ",
                @"  |Round 2:   Chiến thắng khi bạn trả lời đúng 10 câu hỏi về UEH Green                           |  ",
                @"  |                                                                                              |  ",
                @"  |Luật chơi: Bạn được phép trả lời sai 2 câu. Sai 3 câu trò chơi sẽ kết thúc                    |  ",
                @"  |           Lưu lại bút danh (tối đa 22 kí tự, không vượt qua khung)                           |  ",
                @"  |                                       để ghi nhận thành quả hoàn thành Chiến Sĩ Xanh         |  ",
                @"  |Xếp loại: CS1(0-4): Tìm hiểu thêm nhé!                                                        |  ",
                @"  |          CS2(5-9): Cố gắng vào lần sau!                                                      |  ",
                @"  |          CS3(10-14): Bạn đã có kiến thức cơ bản về UEH Green rồi!                            |  ",
                @"  |          CS4(15-19): Bạn đã tiến gần đến danh hiệu Chiến Sĩ Xanh!                            |  ",
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
        static void SaveAchievement(string Name, int score)
        {
            if (Name != "" && !String.IsNullOrWhiteSpace(Name))
            {
                bool ContainName = false;
                string filePath = "UEHer.txt";

                // Tạo file nếu chưa tồn tại
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close(); // Tạo và đóng file
                }
                string[] OpenSaveFile = File.ReadAllLines(filePath);

                for (int i = 0; i < OpenSaveFile.Length / 3; i += 3)
                {
                    if (OpenSaveFile[i * 3].Contains(Name))
                    {
                        if (score > int.Parse(OpenSaveFile[i + 1]))
                        {

                            OpenSaveFile[i * 3 + 1] = score.ToString();
                            OpenSaveFile[i * 3 + 2] = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
                        }
                        ContainName = true;
                    }
                    if (ContainName) break;
                }
                if (!ContainName)
                {
                    string newEntry = $"Tên người chơi: {Name,-22} || Điểm: {score,-5} || Thời gian: {DateTime.Now:HH:mm dd/MM/yyyy}\n";
                    File.AppendAllText(filePath, newEntry);
                }
                else
                {
                    File.WriteAllLines(filePath, OpenSaveFile);
                }
            }
        }
        static void SaveGameRanking(string YourName, int score)
        {
            // Gọi phương thức CalculateRank để lấy hạng
            string rank = GameRanking.CalculateRank(score);

            // Lưu điểm và hạng vào file
            GameRanking.SaveProgress(YourName, score);

        }
        static void DisplayLeaderboard()
        {
            string filePath = "UEHer.txt";
            Console.CursorVisible = false;

            while (true) // Lặp lại cho tới khi người chơi thoát
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.F) // Nhấn F để hiện bảng thành tích
                {
                    if (!File.Exists(filePath))
                    {
                        Console.WriteLine("Chưa có người chơi nào."); // No players yet
                        continue; // Continue to wait for input
                    }

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    // Define the box lines in an array
                    string[] boxLines = new string[]
                    {
    "╔════════════════════════════════════════╗",
    "║ LỊCH SỬ CHINH PHỤC UEH GREEN CỦA UEHer ║",
    "╚════════════════════════════════════════╝"
                    };

                    // Calculate the starting position for the box to be printed
                    int startPositionX = 120 / 4; // Starting X position
                    int startPositionY = 0; // Starting Y position

                    // Print each line of the box
                    for (int i = 0; i < boxLines.Length; i++)
                    {
                        Console.SetCursorPosition(startPositionX, startPositionY + i); // Set cursor position
                        Console.WriteLine(boxLines[i]); // Print the line
                    }

                    Console.ResetColor();
                    string[] lines = File.ReadAllLines(filePath);

                    // Print all lines from the file
                    foreach (var line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.ForegroundColor= ConsoleColor.DarkYellow;
                    Console.WriteLine("\nNhấn Enter để quay lại."); // Instruction to go back
                    Console.ResetColor();
                    key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Enter)
                    {
                        break; // Exit the file display
                    }
                }
                else if (key == ConsoleKey.Enter) // Exit the program
                {
                    break;
                }
            }
        }
        public static void Shuffle(List<UehQuestion> list)
        {
            Random random = new Random();
            int n = list.Count;

            for (int i = n - 1; i > 0; i--)
            {
                int k = random.Next(0, i + 1);
                UehQuestion temp = list[i];
                list[i] = list[k];
                list[k] = temp;
            }
        }

        public static void ClearQuestionAndAnswer(int startLine, int lineCount)
        {
            for (int i = 0; i < lineCount; i++)
            {
                Console.SetCursorPosition(0, startLine + i);
                Console.Write(new string(' ', Console.WindowWidth));
            }
            Console.SetCursorPosition(0, startLine);
        }

        public static void PositionAtBottom()
        {
            int windowHeight = Console.WindowHeight;
            int bottomPosition = windowHeight = 18;

            Console.SetCursorPosition(0, bottomPosition);
        }
    }
    public class UehQuestion
    {
        public string Question { get; set; }
        public string[] Choices { get; set; }
        public string CorrectAnswer { get; set; }

        public UehQuestion(string question, string[] choices, string correctAnswer)
        {
            Question = question;
            Choices = choices;
            CorrectAnswer = correctAnswer;
        }
    }
}
