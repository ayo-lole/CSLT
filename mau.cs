using System;
using System.IO;

class GameRanking
{
    public static string filePath = "progress.txt";

    // Hàm tính hạng dựa trên số điểm từ trò chơi chính
    public static string CalculateRank(int score2)
    {
        if (score2 <= 5)
        {
            return "CS3";
        }
        else if (score2 <= 10)
        {
            return "CS4";
        }
        else if (score2 == 0)
        {
            return "CS5";
        }
        else
        {
            return "Invalid score";
        }
    }

    // Lưu điểm và hạng vào file sau trò chơi
    public static void SaveProgress(int score2)
    {
        string rank = CalculateRank(score2);
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Score: " + score2);
            writer.WriteLine("Rank: " + rank);
        }
    }

    // Hiển thị kết quả và hạng từ file
    public static void DisplayResult()
    {
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string result;
                while ((result = reader.ReadLine()) != null)
                {
                    Console.WriteLine(result);
                }
            }
        }
        else
        {
            Console.WriteLine("Không có quá trình nào được lưu.");
        }
    }

    // Tích hợp hàm SaveAchievement để lưu thành tích vào file ngoài
    public static void SaveAchievement(string Name, int score2)
    {
        if (!string.IsNullOrWhiteSpace(Name))
        {
            bool ContainName = false;
            string achievementFilePath = "UEHer.txt";

            // Tạo file nếu chưa tồn tại
            if (!File.Exists(achievementFilePath))
            {
                File.Create(achievementFilePath).Close(); // Tạo và đóng file ngay lập tức
            }

            // Đọc nội dung file
            string[] OpenSaveFile = File.ReadAllLines(achievementFilePath);

            // Tìm kiếm tên người chơi và cập nhật nếu cần
            for (int i = 0; i < OpenSaveFile.Length / 3; i += 3)
            {
                if (OpenSaveFile[i * 3].Contains(Name))
                {
                    if (score2 > int.Parse(OpenSaveFile[i + 1]))
                    {
                        OpenSaveFile[i * 3 + 1] = score2.ToString();
                        OpenSaveFile[i * 3 + 2] = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
                    }
                    ContainName = true;
                }
                if (ContainName) break;
            }

            // Nếu tên không tồn tại, thêm người chơi mới
            if (!ContainName)
            {
                string rank = CalculateRank(score2); // Gọi hàm tính hạng
                string newEntry = $"Tên người chơi: {Name,-22} || Điểm: {score2,-5} || Thứ hạng: {rank,-3} || Thời gian: {DateTime.Now:HH:mm dd/MM/yyyy}\n";
                File.AppendAllText(achievementFilePath, newEntry);
            }
            else
            {
                // Nếu tên đã tồn tại và điểm được cập nhật, ghi lại toàn bộ dữ liệu
                File.WriteAllLines(achievementFilePath, OpenSaveFile);
            }
        }
    }
}

class Programm
{
    static void Main(string[] args)
    {
        // Đây là nơi gọi hàm và xử lý điểm số từ trò chơi chính
        string playerName = "Người chơi";  // Thay thế bằng tên người chơi thực tế
        int playerScore2 = 12; // Thay thế giá trị này bằng số điểm thực tế từ trò chơi

        // Lưu điểm và hạng vào file progress.txt
        GameRanking.SaveProgress(playerScore2);

        // Lưu thành tích và hạng vào file UEHer.txt
        GameRanking.SaveAchievement(playerName, playerScore2);
        GameRanking.DisplayResult();
    }
}
