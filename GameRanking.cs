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
        $@"||           Số điểm cuối cùng của bạn là: {score,-2}             ||",
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
                if (art[i].Contains("c" + "@")) // Đặt màu xanh lá cho phần có chữ 'c'
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (art[i].Contains("═"))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;                   
                }
                else if (art[i].Contains("║"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else // Đặt màu trắng cho phần còn lại
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.SetCursorPosition(x, y + i);  // Đặt vị trí dòng tiếp theo
                Console.WriteLine(art[i]);  // In từng dòng của mảng art
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
        public static void SaveAchievement(string Name, int score)
        {
            if (Name != "" && !String.IsNullOrWhiteSpace(Name)) //Đảm bảo rằng tên người chơi hợp lệ trước khi tiếp tục lưu thành tích. Nếu tên rỗng hoặc chỉ chứa khoảng trắng, phương thức sẽ không thực thi.
            {
                bool ContainName = false; //Biến này được sử dụng để kiểm tra xem tên người chơi có tồn tại trong tệp lưu thành tích không.
                string filePath = "UEHer.txt"; //Xác định tệp tin mà thành tích của người chơi sẽ được lưu hoặc đọc từ đó.

                // Tạo file nếu chưa tồn tại
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close(); // Tạo và đóng file
                }
                string[] OpenSaveFile = File.ReadAllLines(filePath); //Lấy dữ liệu hiện có từ tệp lưu để kiểm tra và cập nhật nếu cần.

                for (int i = 0; i < OpenSaveFile.Length / 3; i += 3) 
                    /*Ý nghĩa: Vòng lặp duyệt qua tệp tin, giả sử mỗi thành tích người chơi được lưu trên 3 dòng (tên người chơi, điểm, thời gian).
                    Mục đích: Duyệt qua các thành tích cũ để kiểm tra xem tên người chơi hiện tại đã tồn tại hay chưa.*/
                {
                    if (OpenSaveFile[i * 3].Contains(Name)) //Kiểm tra xem dòng đầu tiên của mỗi mục (giả định là tên người chơi) có chứa tên người chơi hiện tại (Name) không.
                    {
                        if (score > int.Parse(OpenSaveFile[i + 1])) //Kiểm tra xem điểm số mới (score) có lớn hơn điểm số cũ đã lưu (ở dòng thứ 2) không. Nếu điểm số mới lớn hơn điểm số cũ, chương trình sẽ cập nhật thành tích.
                        {
                            OpenSaveFile[i * 3 + 1] = score.ToString(); //Cập nhật điểm số mới vào dòng thứ 2 (điểm số cũ).
                            OpenSaveFile[i * 3 + 2] = DateTime.Now.ToString("HH:mm dd/MM/yyyy"); //Cập nhật thời gian mới nhất vào dòng thứ 3 (thời gian cũ).
                        }
                        ContainName = true; //Đánh dấu rằng người chơi đã tồn tại trong tệp lưu.
                    }
                    if (ContainName) break; // Tránh tiếp tục duyệt qua tệp nếu đã tìm thấy và cập nhật người chơi.
                }
                if (!ContainName) //Nếu tên người chơi không tồn tại, chương trình sẽ thêm thành tích mới.
                {
                    string newEntry = $"Tên người chơi: {Name,-22} || Điểm: {score,-5} || Thời gian: {DateTime.Now:HH:mm dd/MM/yyyy}\n"; // Cài vị trí sẽ in ra trong filefile
                    File.AppendAllText(filePath, newEntry); //Thêm thành tích của người chơi mới vào tệp.
                }
                else
                {
                    File.WriteAllLines(filePath, OpenSaveFile); //Nếu tên người chơi đã tồn tại và đã được cập nhật, ghi lại toàn bộ nội dung đã chỉnh sửa vào tệp.
                }
            }
        }
    }
}
