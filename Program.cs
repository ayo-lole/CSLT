using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Net;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Schema;
using System.Numerics;

namespace UEH_Green
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
            new string[] { "A) Thùng rác thực phẩm", "B) Thùng rác giấy", "C) Thùng rác nhựa", "D) Thùng rác kim loại" }, "A"),
        new UehQuestion(
            "Dự án đầu tiên mở đầu cho dự án \"UEH Zero Waste Campus\" có tên là gì?",
        new string[] {
            "A) UEH Green Community", "B) Rethink & Be Green", "C) Reduce - Reuse - Recycle", "D) Keep The Earth Green" }, "B"),
        new UehQuestion(
            "Dự án \"UEH Zero Waste Campus\" đang trong giai đoạn thứ mấy?",
        new string[] { "A) 4", "B) 5", "C) 3", "D) 6" }, "A"),
new UehQuestion(
    "Loại rác thải nào sau đây không có trong mô hình 7?",
    new string[] { "A) Đinh ốc", "B) Bìa Carton", "C) Pin", "D) Thực phẩm thừa" }, "C"),
new UehQuestion(
    "UEH Green Campus hợp tác với tổ chức nào để thúc đẩy sáng kiến không rác thải?",
    new string[] { "A) World Bank", "B) Vietnam Zero Waste Alliance", "C) UNEP (Chương trình Môi trường Liên Hợp Quốc)", "D) GreenPeace" }, "B"),
new UehQuestion(
    "Cuộc thi nào đã giúp UEH Green Campus trở thành quán quân quốc tế?",
    new string[] { "A) \"Thách thức Thành phố Không Rác Thải\"", "B) \"Thách thức Sáng tạo Đại học xanh\"", "C) \"Thách thức Năng lượng Tái tạo\"", "D) \"Thách thức Bảo vệ môi trường quốc tế\"" }, "A"),
new UehQuestion(
    "UEH Green Campus có kế hoạch giảm bao nhiêu phần trăm lượng rác thải được chôn lấp?",
    new string[] { "A) 50%", "B) 65%", "C) 70%", "D) 80%" }, "B"),
new UehQuestion(
    "Sự kiện \"UEH Green Day\" thường niên có chủ đề chính là gì?",
    new string[] { "A) \"Tái chế rác thải nhựa\"", "B) \"Sống mới với cũ\"", "C) \"Bảo vệ nguồn nước\"", "D) \"Giảm thiểu khí thải CO2\"" }, "B"),
new UehQuestion(
    "Mục tiêu chính của dự án UEH Green Campus là gì?",
    new string[] { "A) Tăng số lượng sinh viên đăng ký", "B) Xây dựng khuôn viên xanh, bền vững", "C) Mở rộng quy mô trường đại học", "D) Thúc đẩy tiêu thụ năng lượng tái tạo" }, "B"),
new UehQuestion(
    "Hoạt động nào của sinh viên UEH trong chương trình \"Công dân Xanh UEH\" được nhắc đến?",
    new string[] { "A) Trao đổi rác lấy quà tặng xanh", "B) Thiết kế trang phục thời trang", "C) Chạy đua bảo vệ môi trường", "D) Mua sắm vật dụng xanh" }, "A"),
new UehQuestion(
    "Trong năm 2023, mục tiêu của dự án UEH Green Campus là gì?",
    new string[] { "A) Không có thay đổi nào", "B) Tăng tiêu thụ nhựa dùng một lần", "C) Giảm thiểu rác thải và thay đổi hành vi cộng đồng", "D) Xây dựng thêm các khuôn viên mới" }, "C"),
new UehQuestion(
    "\"Công dân Xanh UEH\" là gì?",
    new string[] { "A) Một sự kiện thể thao", "B) Một chương trình đào tạo", "C) Một cuộc thi sáng tạo xanh", "D) Một sáng kiến xây dựng thói quen sống xanh và bền vững" }, "D"),
new UehQuestion(
    "UEH Green Campus tổ chức sự kiện nào để giúp sinh viên tiếp cận với các hoạt động sống xanh?",
    new string[] { "A) UEH Cultural Festival", "B) UEH Sports Day", "C) UEH Green Day", "D) UEH Job Fair" }, "C"),
new UehQuestion(
    "Để thực hiện tốt hơn việc quản lý rác thải, UEH đã tiến hành hoạt động nào sau đây??",
    new string[] { "A) Nâng cấp các cụm thùng rác thành Trạm thực hành xanh", "B) Mở rộng thêm các bãi rác", "C) Tăng lượng rác thải chôn lấp", "D) Đóng cửa các trạm tái chế" }, "A"),
new UehQuestion(
    "Trạm thực hành xanh (Go Green Station) tại UEH sử dụng mô hình phân loại rác nào?",
    new string[] { "A) 2 loại", "B) 3 loại và 7 loại", "C) 5 loại", "D) 10 loại" }, "B"),
new UehQuestion(
    "\"Bộ quy tắc Đại học xanh\" của UEH bao gồm thực hành nào sau đây?",
    new string[] { "A) Tăng tiêu thụ nước đóng chai", "B) Phân loại rác thải", "C) Sử dụng xe ô tô riêng", "D) Mua sắm vật dụng dùng một lần" }, "B")
        };

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            //Xử lý ngoại lệ lỗi kích thước màn hình trò chơi	
            try
            {
                if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                {
                    int maxWidth = 120;
                    int maxHeight = 27;

                    int newWidth = Math.Min(Console.LargestWindowWidth, maxWidth);
                    int newHeight = Math.Min(Console.LargestWindowHeight, maxHeight);

                    if (newWidth > 0 && newHeight > 0)
                    {
                        Console.SetWindowSize(newWidth, newHeight);
                    }
                    else
                    {
                        Console.WriteLine("Kích thước cửa sổ không hợp lệ.");
                    }
                }
            }
            catch (PlatformNotSupportedException)
            {
                Console.WriteLine("Hệ điều hành không hỗ trợ thay đổi kích thước cửa sổ console.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Giá trị kích thước không hợp lệ.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Lỗi I/O khi thay đổi kích thước cửa sổ: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Không thể thay đổi kích thước cửa sổ console: " + ex.Message);
                // Log lỗi chi tiết nếu cần
            }
            Console.Clear();
            // Giao diện đầu vào trò chơi
            // Khởi tạo đối tượng MusicPlayer với đường dẫn tới file WAV
            // Phát nhạc nền ban đầu
            MusicManager.PlayMusic("C:\\Users\\ASUS\\source\\repos\\test test nè he\\FIFIFINAL\\BGMround1.wav");

            Console.CursorVisible = false; //Không hiện con trỏ chuột
            GiaoDien intro = new GiaoDien(); //Đoạn mã này tạo ra một đối tượng của lớp GiaoDien và sau đó gọi phương thức DisplayIntro() của đối tượng đó.
            intro.DisplayIntro(); //Thực hiện chức năng
            Console.ReadLine(); // Đợi người dùng nhập tiếp 
            Console.Clear();

            //Giao diện giới thiệu game  
            string[] myArray = GiaoDien.Bangmota(10, 1);

            //Bảng điền tên 
            string YourName = GiaoDien.InputPlayerName();

            // Giao diện chuyển cảnh trước khi bắt đầu trò chơi hỏi xem người chơi có muốn xem lịch sử trước đó không          
            GiaoDien.PrintEnterNFBanner();
            GiaoDien lan1 = new GiaoDien();
            lan1.DisplayLeaderboard(); //Gọi hàm này để kiểm tra phím bấm vào F thì hiện lịch sử, Enter thì vào chơi 
            Console.Clear();

            string[] runningAnimation =
                {
	#region Frames
	// 0
	@"       " + '\n' +
    @"  UEHer" + '\n' +
    @"  __O  " + '\n' +
    @" / /\_," + '\n' +
    @"__/\   " + '\n' +
    @"    \  ",
	// 1
	@"       " + '\n' +
    @"  UEHer" + '\n' +
    @"   _O  " + '\n' +
    @"  |/|_ " + '\n' +
    @"  /\   " + '\n' +
    @" /  |  ",
	// 2
	@"       " + '\n' +
    @"  UEHer" + '\n' +
    @"    O  " + '\n' +
    @"  </L  " + '\n' +
    @"   \   " + '\n' +
    @"   /|  ",
	// 3
	@"       " + '\n' +
    @"  UEHer" + '\n' +
    @"   O   " + '\n' +
    @"   |_  " + '\n' +
    @"   |>  " + '\n' +
    @"  /|   ",
	// 4
	@"       " + '\n' +
    @"  UEHer" + '\n' +
    @"   O   " + '\n' +
    @"  <|L  " + '\n' +
    @"   |_  " + '\n' +
    @"   |/  ",
	// 5
	@"       " + '\n' +
    @"  UEHer" + '\n' +
    @"   O   " + '\n' +
    @"  L|L  " + '\n' +
    @"   |_  " + '\n' +
    @"  /  | ",
	// 6
	@"       " + '\n' +
    @"  UEHer" + '\n' +
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


              @"       " + '\n' +
              @" ____  " + '\n' +
              @" ║♻️║  " + '\n' +
              @" \__/  ";
            #endregion
            int position = 4; //Biến vị trí của nhân vật
            int? runningFrame = 0;
            int? jumpingFrame = null;
            bool isStopped = false;
            int targetPosition = 100; //vị trí dừng lại trước vật cản ban đầu 
            Shuffle(questions); // Dùng thuật toán Fisher-Yates để trộn câu hỏi
            int score = 0;
            int wrongAnswers = 0;
            int health = 3; // Khai báo trái tim ban đầu mình có
            const int MaxHealth = 3;
            Console.CursorVisible = false; //Ẩn con trỏ chuột đi để giao diện trông đẹp hơn không bị rối

            while (true)
            {
                GiaoDien.esc();
                // Vẽ con đường
                GiaoDien.Road();
                // Vẽ đám mây    
                GiaoDien.Cloud();
                // Vẽ khung chứa tên và in điểm ra sau mỗi lần trả lời đúng
                GiaoDien.DrawFrame(YourName);
                // Vẽ khung chứa trái tim và thùng rác, và mỗi lần trả lời sai sẽ có sự thay đổi giữa hai biểu tượng dựa vào biến health
                GiaoDien.DrawHealthBar(health, MaxHealth);
                //Cập nhật khung hình
                UpdateFrame();

                
                //Kiểm tra phím nhấn nếu bấm Esc sẽ thoát khỏi trò chơi
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key; // Kiểm tra phím đầu vào
                    if (key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(120 / 3, 27 / 2);
                        Console.Write("TRÒ CHƠI KẾT THÚC!");
                        Console.ReadKey();
                        return;
                    }
                }
                RenderHurdles(false, targetPosition);
                //Dừng lại trước vật cản 
                if (position >= targetPosition - 6)
                {

                    // Lượt qua các câu hỏi  
                    foreach (var question in questions.ToList())
                    {
                        if (wrongAnswers == 3)// Thua trò chơi
                        {

                            // Khởi tạo đối tượng MusicPlayer với đường dẫn tới file WAV
                            Thread.Sleep(500); // Mô phỏng thời gian
                            MusicManager.PlayMusic("C:\\Users\\ASUS\\source\\repos\\test test nè he\\FIFIFINAL\\GameOver.wav");

                            Console.Clear();
                            GameRanking.SaveAchievement(YourName, score); // Sau khi thua thì lưu tên và điểm vào file
                            GameRanking.SaveProgress(YourName, score); // Hiện điểm và rank 

                            GiaoDien lan2 = new GiaoDien();
                            lan2.DisplayLeaderboard();//Xem lịch sử sau khi thua                           
                            return; // Thoát trò chơi
                        }
                        //Hiển thị câu hỏi và đáp án ở phía dưới màn hình
                        UehQuestionHandle.PositionAtBottom();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nQuestion: " + question.Question);
                        Console.ResetColor();

                        foreach (var choice in question.Choices)
                        {
                            Console.WriteLine(choice);
                        }
                        int questionCursorTop = Console.CursorTop - (question.Choices.Length + 1); //Đặt vị trí con trỏ bắt đầu xóa

                        string userAnswer = ""; // Để nhận từ người chơi chỉ 1 kí tự
                        bool isValidAnswer = false; // Đánh dấu cho đầu vào hợp lệ

                        while (!isValidAnswer) // Tạo vòng lặp trả lời đến khi người chơi nhập đúng ABCD
                        {
                            try
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Điền A, B, C, hoặc D để trả lời: ");
                                Console.ResetColor();
                                // Đợi người chơi nhập đáp án                 
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                userAnswer = Console.ReadKey().KeyChar.ToString().ToUpper();

                                Console.ResetColor();
                                // Kiểm tra giá trị nhập vào 
                                if (!new[] { "A", "B", "C", "D" }.Contains(userAnswer))
                                {
                                    // Nếu nhập không đúng yêu cầu
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    throw new InvalidOperationException("Phím không hợp lệ. Vui lòng nhập A, B, C, hoặc D.");
                                }
                                // Nếu nhập đúng A B C D thì thoát ra khỏi vòng lặp 
                                isValidAnswer = true;
                            }
                            catch (InvalidOperationException ex)
                            {
                                // Xử lý ngoại lệ đầu vào không hợp lệ
                                Console.WriteLine($"\n{ex.Message}");

                                // Di chuyển con trỏ lên trên để tránh lộn xộn từ việc nhập dữ liệu không hợp lệ lặp lại
                                Console.SetCursorPosition(0, Console.CursorTop - 2);
                            }
                        }

                        //Xử lí đáp án 
                        if (userAnswer == question.CorrectAnswer)
                        {
                            string filePath = @"C:\Users\ASUS\source\repos\test test nè he\FIFIFINAL\Correct.wav";
                            MusicPlayer musicPlayer = new MusicPlayer(filePath);

                            // Phát nhạc chiến thắng trong một luồng mới
                            musicPlayer.PlayMusicInNewThread();

                            score++;
                            GiaoDien.TinhDiem(score);
                            jumpingFrame = 0; //Bắt đầu khung hình nhảy
                            runningFrame = null; //Tắt trạng thái chạy
                            isStopped = false; //Dừng đứng yên 
                            targetPosition += 50; // tăng vị trí sẽ dừng lại sau mỗi lần trả lời đúng 
                            questions.Remove(question); //Dù trả lời sai hay đúng thì câu hỏi đó cũng sẽ biến mất khỏi bộ câu hỏi
                            MusicManager.PlayMusic("C:\\Users\\ASUS\\source\\repos\\test test nè he\\FIFIFINAL\\BGMround1.wav");
                        }

                        else
                        {
                            string filePath = @"C:\Users\ASUS\source\repos\test test nè he\FIFIFINAL\Wrong.wav";
                            MusicPlayer musicPlayer = new MusicPlayer(filePath);

                            // Phát nhạc chiến thắng trong một luồng mới
                            musicPlayer.PlayMusicInNewThread();
                            position--; //trừ lại vị trí nhân vật sau mỗi lần trả lời sai để không bị trùng vị trị vật cản
                            wrongAnswers++;
                            health--;
                            questions.Remove(question);
                            MusicManager.PlayMusic("C:\\Users\\ASUS\\source\\repos\\test test nè he\\FIFIFINAL\\BGMround1.wav");
                        }
                        UehQuestionHandle.ClearQuestionAndAnswer(questionCursorTop, question.Choices.Length + 1); // Trả lời đúng hoặc thì xóa đi để hiện câu khác 
                        break;
                    }

                    if (score == 20) //Chiến thắng round 1
                    {

                        // Khởi tạo đối tượng MusicPlayer với đường dẫn tới file WAV
                        Thread.Sleep(500); // Mô phỏng thời gian
                        MusicManager.PlayMusic("C:\\Users\\ASUS\\source\\repos\\test test nè he\\FIFIFINAL\\Victory.wav");

                        Console.Clear();
                        GameRanking.SaveAchievement(YourName, score); //Lưu lại điểm chiến thắng của người chơi
                        GiaoDien.PrintArt(Console.WindowWidth / 3, Console.WindowHeight / 7); //In màn hình thắng round 1
                        GiaoDien lan3 = new GiaoDien(); //Sử dụng phím F hoặc Enter 
                        lan3.DisplayLeaderboard();

                        Console.Clear();
                        Round2.Round_2(); //Chuyển qua round 2
                        return;
                    }
                }
                else
                {
                    isStopped = false; //Nếu không gặp vật cản thì đi tiếp
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
                // Nếu đang không dừng lại thì biến vị trí nhân vật tăng lên
                if (!isStopped)
                {
                    position++;
                }
                Thread.Sleep(TimeSpan.FromMilliseconds(20)); //Tốc độ di chuyển của nhân vật
            }
            //Cập nhật khung hình 
            void UpdateFrame()
            {
                /* Sử dụng toán tử điều kiện (?:) để chọn một chuỗi hoạt ảnh dựa trên trạng thái của biến jumpingFrame và runningFrame.
                  jumpingFrame.HasValue: Kiểm tra xem jumpingFrame có giá trị hay không (biến jumpingFrame là kiểu nullable, tức là có thể chứa giá trị null hoặc một giá trị số nguyên).
                    + Nếu jumpingFrame có giá trị (có nghĩa là nhân vật đang trong trạng thái nhảy): jumpingAnimation[jumpingFrame.Value]: Sẽ lấy khung (frame) tương ứng từ mảng jumpingAnimation dựa trên giá trị của jumpingFrame.
                    + Nếu jumpingFrame không có giá trị (tức là không phải trạng thái nhảy):runningAnimation[runningFrame.GetValueOrDefault()]: Sẽ lấy khung từ mảng runningAnimation, dựa trên giá trị của runningFrame. 
                      Nếu runningFrame là null, thì GetValueOrDefault() sẽ trả về giá trị mặc định (thường là 0 cho kiểu số nguyên). */
                string playerFrame =
                   jumpingFrame.HasValue ? jumpingAnimation[jumpingFrame.Value] :
                   runningAnimation[runningFrame.GetValueOrDefault()];
                // Vẽ lại khung hình của người chơi.
                Console.SetCursorPosition(4, 11);  // Đặt con trỏ tại vị trí của người chơi.
                Render(playerFrame, true);  // Vẽ khung hình của người chơi (có khoảng trắng).

                // Vẽ chướng ngại vật.
                RenderHurdles(true, targetPosition);  // Vẽ chướng ngại vật dựa trên `targetPosition`.

                // Nếu vị trí của người chơi cách 5 đơn vị trong chu kỳ 50.
                if (position % 50 == 5)
                {
                    // Xóa chướng ngại vật khi người chơi chạm vào nó.
                    Console.SetCursorPosition(0, 13);  // Đặt lại vị trí con trỏ.
                    Render(
                        @"       " + '\n' +  // Vẽ khoảng trống để "xóa" chướng ngại vật.
                        @"       " + '\n' +
                        @"       " + '\n' +
                        @"       ", true);  // Xóa bằng cách vẽ khoảng trắng.
                }

                // Nếu vị trí của người chơi gần đầu chu kỳ 50 (vị trí nhỏ hơn 3 đơn vị).
                if (position % 50 < 3)
                {
                    // Xóa khung hình và chướng ngại vật để làm mờ (di chuyển).
                    Console.SetCursorPosition(4, 11);
                    Render(playerFrame, false);  // Vẽ lại khung hình của người chơi (không khoảng trắng).

                    RenderHurdles(false, targetPosition);  // Vẽ lại chướng ngại vật (không khoảng trắng).
                }
                else
                {
                    // Tiếp tục vẽ chướng ngại vật và người chơi.
                    RenderHurdles(false, targetPosition);  // Vẽ lại chướng ngại vật.

                    Console.SetCursorPosition(4, 11);  // Đặt lại vị trí con trỏ của người chơi.
                    Render(playerFrame, false);  // Vẽ lại khung hình của người chơi.
                }
            }
            //dùng để vẽ và xóa các hàm kiểu @string như là nhân vật và vật cản
            void Render(string @string, bool renderSpace)
            {
                int x = Console.CursorLeft;
                int y = Console.CursorTop;
                foreach (char c in @string)
                    if (c == '\n') Console.SetCursorPosition(x, ++y);
                    else if (c != ' ' || renderSpace) Console.Write(c);
                    else Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
            }
            //dùng để hiện các vật cản
            void RenderHurdles(bool renderSpace, int targetPositio)
            {
                for (int i = 5; i < Console.WindowWidth - 5 && position < targetPosition - 6; i++)
                {
                    if (position + i >= 100 && (position + i - 7) % 50 is 0)
                    {
                        Console.SetCursorPosition(i - 3, 13);
                        Render(hurdleFrame, renderSpace);
                    }
                }
            }
        }
        //Trộn câu hỏi
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
    }
    //Tạo class về câu hỏi chứa câu hỏi, câu trả lời, và đáp án đúng
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
