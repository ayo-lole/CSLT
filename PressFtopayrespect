static void DisplayLeaderboard()
{
    string filePath = "leaderboard.txt";

    while (true) //cop từ đoạn này
    {
        Console.WriteLine("Nhấn Enter để bắt đầu game, F để xem bảng thành tích.");
        var key = Console.ReadKey(true).Key;

        if (key == ConsoleKey.F)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Chưa có người chơi nào.");
                continue;
            }

            Console.Clear();
            Console.WriteLine("LỊCH SỬ CHINH PHỤC UEH GREEN CỦA UEHer");
            string[] lines = File.ReadAllLines(filePath);
            int linesPerPage = Console.WindowHeight - 2;
            int currentPage = 0;

            while (true)
            {
                Console.Clear();
                int startLine = currentPage * linesPerPage;
                int endLine = Math.Min(startLine + linesPerPage, lines.Length);

                for (int i = startLine; i < endLine; i++)
                {
                    Console.WriteLine(lines[i]);
                }

                Console.WriteLine("\nNhấn PgUp để cuộn lên, PgDown để cuộn xuống, Enter để bắt đầu game.");

                key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.PageUp)
                {
                    if (currentPage > 0)
                    {
                        currentPage--;
                    }
                }
                else if (key == ConsoleKey.PageDown)
                {
                    if (startLine + linesPerPage < lines.Length)
                    {
                        currentPage++;
                    }
                }
                else if (key == ConsoleKey.Enter)
                {
                    break; // Thoát khỏi hiển thị nội dung file
                }
            }
        }
        else if (key == ConsoleKey.Enter)
        {
            break; // Exit the program
        }
    }
}
