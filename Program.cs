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
            Console.CursorVisible = false; //Không hiện con trỏ chuột
            GiaoDien intro = new GiaoDien(); //Đoạn mã này tạo ra một đối tượng của lớp GiaoDien và sau đó gọi phương thức DisplayIntro() của đối tượng đó.
            intro.DisplayIntro(); //Thực hiện chức năng
            Console.ReadLine(); // Đợi người dùng nhập tiếp 
            Console.Clear();

            //Giao diện giới thiệu game  
            string[] myArray = GiaoDien.Bangmota(10, 1);

            //Bảng điền tên 
            string YourName = GiaoDien.InputPlayerName();
            

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


              @"   BIN   " + '\n' +
              @"  ____  " + '\n' +
              @"  ║♻️║ " + '\n' +
              @"  \__/   ";
            #endregion
            int position = 0; //Biến vị trí của nhân vật
            int? runningFrame = 0; //
            int? jumpingFrame = null;//
            int hurdlePosition = 50; //Biến vị trí (đầu tiên) của vật cản
            bool isStopped = false; // 
            const int stopDistance = 10; // Khoảng cách dừng lại trước vật cản
            
            Shuffle(questions); // Dùng thuật toán Fisher-Yates để trộn câu hỏi
            int score = 0;
            int wrongAnswers = 0;
            int health = 3; // Khai báo trái tim ban đầu mình có
            const int MaxHealth = 3;
            Console.CursorVisible = false; //Ẩn con trỏ chuột đi để giao diện trông đẹp hơn không bị rối

            while (true)
            {
		// Vẽ con đường
		GiaoDien.Road();
		// Vẽ đám mây    
		GiaoDien.Cloud();
                // Vẽ khung chứa tên và in điểm ra sau mỗi lần trả lời đúng
                GiaoDien.DrawFrame(YourName);
                // Vẽ khung chứa trái tim và thùng rác, và mỗi lần trả lời sai sẽ có sự thay đổi giữa hai biểu tượng dựa vào biến health
                GiaoDien.DrawHealthBar(health, MaxHealth);
		/* Sử dụng toán tử điều kiện (?:) để chọn một chuỗi hoạt ảnh dựa trên trạng thái của biến jumpingFrame và runningFrame.
              jumpingFrame.HasValue: Kiểm tra xem jumpingFrame có giá trị hay không (biến jumpingFrame là kiểu nullable, tức là có thể chứa giá trị null hoặc một giá trị số nguyên).
               + Nếu jumpingFrame có giá trị (có nghĩa là nhân vật đang trong trạng thái nhảy): jumpingAnimation[jumpingFrame.Value]: Sẽ lấy khung (frame) tương ứng từ mảng jumpingAnimation dựa trên giá trị của jumpingFrame.
               + Nếu jumpingFrame không có giá trị (tức là không phải trạng thái nhảy):runningAnimation[runningFrame.GetValueOrDefault()]: Sẽ lấy khung từ mảng runningAnimation, dựa trên giá trị của runningFrame. 
		     Nếu runningFrame là null, thì GetValueOrDefault() sẽ trả về giá trị mặc định (thường là 0 cho kiểu số nguyên). */ 
                string playerFrame =
                    jumpingFrame.HasValue ? jumpingAnimation[jumpingFrame.Value] :
                    runningAnimation[runningFrame.GetValueOrDefault()];

                //Kiểm tra phím nhấn nếu bấm Esc sẽ thoát khỏi trò chơi
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key; // Kiểm tra phím đầu vào
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
                    isStopped = true;
                    position = hurdlePosition - stopDistance; // Vị trí của nhân vật = vị trí của vật cản - khoảng cách dừng

                    // Lượt qua các câu hỏi  
                    foreach (var question in questions.ToList())
                    {
                        if (wrongAnswers == 3)// Thua trò chơi
                        {
                            Console.Clear();
                            SaveAchievement(YourName, score); // Sau khi thua thì lưu tên và điểm vào file
                            GameRanking.SaveProgress(YourName, score); // Hiện điểm và rank 
                            DisplayLeaderboard(); //Xem lịch sử sau khi thua
                            Console.ReadKey();
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
                        int questionCursorTop = Console.CursorTop - (question.Choices.Length + 1);

                        string userAnswer = "";
                        bool isValidAnswer = false; // Flag for valid input

                        while (!isValidAnswer) // Continue until valid input is provided
                        {
                            try
                            {
                                // Ask the player to input their answer
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Điền A, B, C, hoặc D để trả lời: ");
                                Console.ResetColor();
                                // Get player input
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                userAnswer = Console.ReadKey().KeyChar.ToString().ToUpper();

                                Console.ResetColor();
                                // Check if input is valid
                                if (!new[] { "A", "B", "C", "D" }.Contains(userAnswer))
                                {
                                    // If invalid input, throw an exception
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    throw new InvalidOperationException("Phím không hợp lệ. Vui lòng nhập A, B, C, hoặc D.");
                                }
                                // If valid input, set the flag to true to exit the loop
                                isValidAnswer = true;
                             }
                             catch (InvalidOperationException ex)
                             {
                                // Handle invalid input exception
                                Console.WriteLine($"\n{ex.Message}");

                                // Move cursor up to avoid clutter from repeated invalid input
                                Console.SetCursorPosition(0, Console.CursorTop - 2);
                            }
                        }

                        UehQuestionHandle.ClearQuestionAndAnswer(questionCursorTop, question.Choices.Length + 1);  // Clear the entire screen
                         //Xử lí đáp án 
                        if (userAnswer == question.CorrectAnswer)
                        {
                            score++;
                            GiaoDien.TinhDiem(score);
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
                            UehQuestionHandle.ClearQuestionAndAnswer(questionCursorTop, question.Choices.Length + 1); // Adjust +1 for the question

                            wrongAnswers++;
                            health--;

                            questions.Remove(question);
                        }
                        UehQuestionHandle.ClearQuestionAndAnswer(questionCursorTop, question.Choices.Length + 1);

                        break;
                    }
                    //Hiện hình các cơ sở của UEH giới thiệu về trường
                   //Hiện hình các cơ sở của UEH giới thiệu về trường
                   if(score == 5)
                   {
                       ShowUEHBuilding(GiaoDien.printUEHBuilding1);
                   }
                   if (score == 8)
                   {
                       ShowUEHBuilding(GiaoDien.printUEHBuilding2);
                   }
                   if (score == 12)
                   {
                       ShowUEHBuilding(GiaoDien.printUEHBuilding3);
                   }
                   if (score == 15)
                   {
                       ShowUEHBuilding(GiaoDien.printUEHBuilding4);
                   }
                   if (score == 18)
                   {
                       ShowUEHBuilding(GiaoDien.printUEHBuilding5);
                   }
                    // Chiến thắng round1
                    if (score == 10)
                    {
                        Console.Clear();
                        GiaoDien.PrintArt(Console.WindowWidth / 3, Console.WindowHeight / 7);
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    //Kết thúc toàn game
                    if (score == 20)
                    {
			Console.Clear();
                        SaveAchievement(YourName, score);
                        GiaoDien win = new GiaoDien();
                        win.DisplayPrintWinArt();
			DisplayLeaderboard();
                        Console.ReadKey();    
                        return;
                    }
                }
                else
                {
                    isStopped = false;
                }

                // Xác định khung hình 
                Console.SetCursorPosition(4, 11);
                Render(playerFrame, true);
                RenderHurdles(true);
                if (position % 50 < 3)
                {
                    Console.SetCursorPosition(4, 11);
                    Render(playerFrame, false);
                    RenderHurdles(false);
                }
                else
                {
                    RenderHurdles(false);
                    Console.SetCursorPosition(4, 11);
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
                Thread.Sleep(TimeSpan.FromMilliseconds(15));
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
                Console.SetCursorPosition(0, 13);
                Console.Write(new string(' ', Console.WindowWidth));

                // Vẽ vật cản ở các vị trí hiện tại
                if (position + 50 >= hurdlePosition && position <= hurdlePosition + 10)
                {
                    int hurdleOffset = hurdlePosition - position;
                    // Đảm bảo hurdleOffset không âm và không vượt quá kích thước của cửa sổ
                    hurdleOffset = Math.Max(0, Math.Min(Console.WindowWidth - hurdleFrame.Length, hurdleOffset));
                    Console.SetCursorPosition(hurdleOffset, 13);
                    Render(hurdleFrame, renderEnter);

                }
            }
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
                    string newEntry = $"Tên người chơi: {Name,-22} || Điểm: {score,-5} || Thời gian: {DateTime.Now:HH:mm dd/MM/yyyy}\n"; // Cài vị trí sẽ in ra trong filefile
                    File.AppendAllText(filePath, newEntry);
                }
                else
                {
                    File.WriteAllLines(filePath, OpenSaveFile);
                }
            }
        }
        static void DisplayLeaderboard()
        {
            string filePath = "UEHer.txt";
            Console.CursorVisible = false;
            int consoleWidth = 120;
            int consoleHeight = 27;
            int linesPerPage = consoleHeight - 5; // Trừ đi 5 dòng dành cho tiêu đề và chân trang

            // Thiết lập kích thước console
            Console.SetWindowSize(consoleWidth, consoleHeight);
            Console.SetBufferSize(consoleWidth, consoleHeight);

            while (true) // Vòng lặp cho đến khi người dùng chọn thoát
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.F) // Nhấn phím F để hiển thị bảng xếp hạng
                {
                    if (!File.Exists(filePath))
                    {
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
                            Console.ForegroundColor= ConsoleColor.DarkRed;
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
       static void ShowUEHBuilding(Action printBuilding)
       {
            Console.Clear();
            printBuilding(); // Call the passed-in method to print the building
            Console.ReadKey(); // Wait for a key press
            Console.Clear(); // Clear the console again
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
