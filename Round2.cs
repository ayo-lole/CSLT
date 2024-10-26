using System.Diagnostics;
using System.Text;

namespace UEH_Green
{
    internal class Round2
    {


        public static void Round_2()
        {
            
            char[][][] scores =
    [
        // '@': starting player position
        // ' ': open space
        // '~': switchable open space
        // '█': wall
        // '#': switchable wall
        // 'X': spikey death
        // '●': goal
        
        [
        "██████████████████████████████████████████                                                                      ".ToCharArray(),
        "█            <> CƠ SỞ I <●>              █            _____________________________________________________     ".ToCharArray(),
        "█               __________               █           | Để đáp ứng được yêu cầu và chất lượng học thuật khắt|    ".ToCharArray(),
        "█              |  UEH     |              █           |   khe, hệ thống cơ sở vật chất ở đây cũng thuộc kiểu|    ".ToCharArray(),
        "█         _____|____════════╗            █           |   siêu xịn sò, tạo một môi trường học tập vô cùng vô|    ".ToCharArray(),
        "█         ||   W   |║       ║            █           |   cùng chuyên nghiệp.                               |    ".ToCharArray(),
        "█         ||western|║       ║            █           |                                                     |    ".ToCharArray(),
        "█         || sydney|║       ║            █           | Là ngôi nhà của các ISBers – những cử nhân tài      |    ".ToCharArray(),
        "█         |█████████║███████║            █           |   năng với chương trình học hoàn toàn bằng tiếng Anh|    ".ToCharArray(),
        "█         | █ █ █ █ ║       ║            █           |   và giảng viên nước ngoài.                         |    ".ToCharArray(),
        "█         | █ █ █ █ ║       ║            █            -----------------------------------------------------     ".ToCharArray(),
        "█         |█████████║███████║            █                                                                      ".ToCharArray(),
        "█         | |     | ║       ║            █                                                                      ".ToCharArray(),
        "█         | | ISB | ║       ║            █                                                                      ".ToCharArray(),
        "█         |▄|▄▄▄▄▄|▄▄▄▄▄▄▄▄▄|            ███████████████████████████████████████████████████████████████████████".ToCharArray(),
        "█         |--------|    |   |                                                                                  █".ToCharArray(),
        "█         |--------|    |   |                                                                                  █".ToCharArray(),
        "█         |________|____|___|                                                                                  █".ToCharArray(),
        "█                                                                                                              █".ToCharArray(),
        "█                                                                                                @@@@@         █".ToCharArray(),
        "█                                                                                                @@@@@         █".ToCharArray(),
        "█                                                                                                @@@@@         █".ToCharArray(),
        "████████████████████████████████████████████████████████████████████████████████████████████████████████████████".ToCharArray(),
    ],
    [
        "████████████████████████████████████████████████████████████████████████                                              ".ToCharArray(),
        "█                                       █        <> CƠ SỞ B <●>        █                                              ".ToCharArray(),
        "█                                       █       _________________      █                                              ".ToCharArray(),
        "█                                       █      |___║___║___║__|__|     █                                              ".ToCharArray(),
        "█                                       █      |___║___║___║__|__|     █                                              ".ToCharArray(),
        "█                                       █      |═══║═══║═══║__|__|     █   __________________________________________ ".ToCharArray(),
        "█                                       █      |═══║═══║═══║__|__|     █ | Được mệnh danh là Cơ sở thông minh, đánh  |".ToCharArray(),
        "█                                       █      |═══║═══║═══║__|__|     █ |   dấu bước ngoặt về đổi mới cơ sở vật chất|".ToCharArray(),
        "█                                       █      |═══║═══║═══║__|__|     █ |   theo hướng chuẩn đại học quốc tế của UEH|".ToCharArray(),
        "█                    █                  █      |═══║═══║═══║__|__|     █ |                                           |".ToCharArray(),
        "█                    █                  █      |═══║═══║═══║__|__|     █ | Được xem là trung tâm của mọi hoạt động   |".ToCharArray(),
        "█                    █                  █      |═══║═══║═══║__|__|     █ |   học tập, là nơi đặt văn phòng của các   |".ToCharArray(),
        "█                    █                  █      |═══║═══║═══║══|══|     █ |   khoa để các bạn sinh viên có thể dễ dàng|".ToCharArray(),
        "█                    █                  █      |_ĐẠI HỌC KINH TẾ_|     █ |   được giải đáp thắc mắc và hướng dẫn các |".ToCharArray(),
        "█                    █                         |===║===║===║__║__|     █ |   vấn đề liên đến học thuật.              |".ToCharArray(),
        "█      @@@@@         █                         |   ║   ║   ║__║__|     █  ------------------------------------------- ".ToCharArray(),
        "█      @@@@@         █                         |___║___║___║__║__|     █                                              ".ToCharArray(),
        "█      @@@@@         █                         |   ║   ║   ║  ║  |     █                                              ".ToCharArray(),
        "█                    █                         |___║___║___║__║__|     █                                              ".ToCharArray(),
        "█                    █                                                 █                                              ".ToCharArray(),
        "█                    █                                                 █                                              ".ToCharArray(),
        "████████████████████████████████████████████████████████████████████████                                              ".ToCharArray(),
    ],

    [
        "██████████████████████████████████████████████████████████████████████████████████████████████████████████████████".ToCharArray(),
        "█XXXXXXX                                 ____________________________________________________________________    █".ToCharArray(),
        "█XXXXXXX                                |          ║║ | | | | | | | | | | | | | |║║   ||  ||||  ||||  ||||   |   █".ToCharArray(),
        "█XXXXXXX                                |__________║║ | | | | | | | | | | | | | |║║   ||  ||||  ||||  ||||   |   █".ToCharArray(),
        "█XXXXXXX          █                     |   UEH    ║║_|_|_|_|_|_|_|_|_|_|_|_|_|_|║║═══||══||||══||||══||||═══|   █".ToCharArray(),
        "█XXXXXXX          █                     |university║║ | | | | | | | | | | | | | |║║   ||  ||||  ||||  ||||   |   █".ToCharArray(),
        "█XXXXXXX          █                     |__________║║ | | | | | | | | | | | | | |║║═══||══||||══||||══||||═══|   █".ToCharArray(),
        "█XXXXXXX          █                     |          ║╚════════════════════════════╝║   ||  ||||  ||||  ||||   |   █".ToCharArray(),
        "█XXXXXXX          █                     |          ║  ║  ║  ║  ║  ║  ║  ║  ║  ║   ║___||__||||__||||__||||___|   █".ToCharArray(),
        "█XXXXXX█          █                     |          ║  ║  ║  ║  ║  ║  ║__║__║__║___║   ║   ║   ║   ║   ║   ║  |   █".ToCharArray(),
        "█XXXXXX█          █                     |          ║  ║  ║  ║  ║  ║  ║  ║  ║  ║   ║   ║   ║   ║   ║   ║   ║  |   █".ToCharArray(),
        "█XXXXXX█          █     <> CƠ SỞ A <●>  |__________║__║__║__║__║__║__║  ║  ║  ║   ║___║___║___║___║___║___║__|   █".ToCharArray(),
        "████████          ████████████████████████████████████████████████████████████████████████████████████████████████".ToCharArray(),
        "█                                                               █    ____________________________________________ ".ToCharArray(),
        "█                                                               █   | Đây chính là trụ sở chính của UEH. Là cơ sở|".ToCharArray(),
        "█                                                               █   |   lâu đời, mang giá trị truyền thống lịch  |".ToCharArray(),
        "█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█          █XXXXXXXXXXX█   |   sử, văn hóa, gắn bó với nhiều thế hệ     |".ToCharArray(),
        "██████████████████████████████████████████          █████████████   |   giảng viên và sinh viên.                 |".ToCharArray(),
        "█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█          █XXXXXXXXXXX█   |                                            |".ToCharArray(),
        "█    @@@@@                                                      █   | Là địa điểm quen thuộc khi sinh viên có vấn|".ToCharArray(),
        "█    @@@@@                                                      █   |    đề, thủ tục liên quan đến hồ sơ giấy tờ |".ToCharArray(),
        "█    @@@@@                                                      █   |    như cấp giấy chứng nhận sinh viên,...   |".ToCharArray(),
        "█████████████████████████████████████████████████████████████████    -------------------------------------------- ".ToCharArray(),
    ],
    [
        "█████████████████████████████████████████████████████████████████████                                                 ".ToCharArray(),
        "█                                   ~                               █                                                 ".ToCharArray(),
        "█                                   ~      ____________________     █                                                 ".ToCharArray(),
        "█                                   ~     |        ║     ║_____|    █                                                 ".ToCharArray(),
        "█                                   ~     |   _____║     ║||||||    █  _____________________________________________  ".ToCharArray(),
        "█                                   ~     |___|||||║     ║═════|    █ | Được đánh giá là cơ sở yên tĩnh nhất, gây ấn| ".ToCharArray(),
        "█                                   ~     |        ║     ║_____|    █ |   tượng với quầy tự quản và thư viện chuyên | ".ToCharArray(),
        "█###################################█     |   _____║ UEH ║||||||    █ |   ngành hiện đại.                           | ".ToCharArray(),
        "█                                   █     |___|||||║.....║═════|    █ |                                             | ".ToCharArray(),
        "█                                   █     |        ║.....║_____|    █ | Sinh viên năm nhất khả năng cao sẽ học tiếng| ".ToCharArray(),
        "█                                   █     |   _____║     ║||||||    █ |   Anh tổng quát tại đây.                    | ".ToCharArray(),
        "█                                   █     |___|||||║     ║═════|    █ |                                             | ".ToCharArray(),
        "█                                   █     |   _____║     ║_____|    █ | Fun fact: Đứng ở ban công cơ sở này có thể  | ".ToCharArray(),
        "█                                   █     |   |||||║     ║||||||    █ |   mang lại cảm giác rất dễ chịu, đặc biệt là| ".ToCharArray(),
        "█      @@@@@                        █     |========╚═════╝═════|    █ |   khi thời tiết trong lành và có gió mát.   | ".ToCharArray(),
        "█      @@@@@                        █     |     ║  |           |    █ |   Sinh viên UEH nên một lần đến đây để trải | ".ToCharArray(),
        "█      @@@@@                        █     |     ║  |           |    █ |   nghiệm.                                   | ".ToCharArray(),
        "█                                   █     |_____║__|___________|    █  ---------------------------------------------  ".ToCharArray(),
        "█                                   █                               █ 1A Hoàng Diệu, phường 10, Quận Phú Nhuận, TP.HCM".ToCharArray(),
        "█                                   █         <> CƠ SỞ H <●>        █                                                 ".ToCharArray(),
        "█████████████████████████████████████████████████████████████████████                                                 ".ToCharArray(),
    ],
    [
        "██████████████████████████████████████████████████████████████████                                              ".ToCharArray(),
        "█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█                                              ".ToCharArray(),
        "█X###############################################################█                                              ".ToCharArray(),
        "█X~                   _________                                  █                                              ".ToCharArray(),
        "█X~     ______________║ ║   ║ ║______________                    █  ___________________________________________ ".ToCharArray(),
        "█X~    |              ║ ║   ║ ║              |                   █ | Là cơ sở hiện đại bậc nhất UEH với quy mô |".ToCharArray(),
        "█X~    |              ║ ║   ║ ║              |                   █ |  rộng 11ha, thiết kế hiện đại, tiện ích   |".ToCharArray(),
        "█X~    |           ___║ ║ U ║ ║___           |                   █ |  theo hướng trường đại học xanh gần gũi   |".ToCharArray(),
        "█X~    |          ║   ║ ║ E ║ ║   ║          |   █               █ |  với thiên nhiên.                         |".ToCharArray(),
        "█X~    |       ___║   ║ ║ H ║ ║   ║___       |   █               █ |                                           |".ToCharArray(),
        "█X~    |      ║   ║   ║ ║   ║ ║   ║   ║      |   █               █ | Fun fact: Nhiều sinh viên thường sử dụng  |".ToCharArray(),
        "█X~    |      ║   ║   ║ ║   ║ ║   ║   ║      |   █               █ |   UEH Shuttle Bus để đến cơ sở này vì nó  |".ToCharArray(),
        "█X~    |      ║   ║   ║ ║   ║ ║   ║   ║      |   █               █ |   nằm ở tận Nguyễn Văn Linh, Bình Chánh.  |".ToCharArray(),
        "█X~    |   ___║   ║   ║ ╚═══╝ ║   ║   ║___   |   █               █  ------------------------------------------- ".ToCharArray(),
        "█X~    |  ║   ║   ║   ║  _ _  ║   ║   ║   ║  |   █               █                                              ".ToCharArray(),
        "█X~    |  ║   ║   ║   ║ | | | ║   ║   ║   ║  |   █               █                ╔═══════════════╗             ".ToCharArray(),
        "█X~    |__║___║___║___║_|_|_|_║___║___║___║__|   █               █                ║  ______--___  ║             ".ToCharArray(),
        "█X~                 <> CƠ SỞ N <●>               █               █                ║ / []    ----` ║             ".ToCharArray(),
        "██████████████████████████████████████████████████             ███                ║ ------() UEH  ║             ".ToCharArray(),
        "█      @@@@@                                     #             ~X█                ╚═══════════════╝             ".ToCharArray(),
        "█      @@@@@                                     #             ~X█                 UEH Shuttle Bus              ".ToCharArray(),
        "█      @@@@@                                     #             ~X█                                              ".ToCharArray(),
        "██████████████████████████████████████████████████████████████████                                              ".ToCharArray(),
    ],
];
            // Nhạc nền round 2
            MusicManager.PlayMusic("C:\\Users\\ASUS\\source\\repos\\test test nè he\\FIFIFINAL\\BGMround2.wav");
            Stopwatch stopwatch = Stopwatch.StartNew(); //Lớp Stopwatch được sử dụng để đo khoảng thời gian và việc bắt đầu nó ở đầu vòng lặp trò chơi (hoặc một giai đoạn trò chơi khác) cho phép theo dõi thời gian đã trôi qua
            bool closeRequested = false;
            int score = 0; //Khai báo biến điểm để tính cơ sở
            (int X, int Y) velocity = (0, 0); //Bộ ba này biểu diễn vận tốc của người chơi trên cả trục X (ngang) và trục Y (dọc). Ban đầu, nó được đặt thành (0, 0), nghĩa là người chơi đứng yên. Giá trị này thường sẽ được cập nhật dựa trên đầu vào của người chơi (ví dụ: di chuyển sang trái, phải hoặc nhảy).         
            int updatesSinceSlideApplied = 0; //Bộ đếm này theo dõi số lượng bản cập nhật (hoặc khung hình) đã xảy ra kể từ khi hành động trượt được áp dụng. Nó giúp kiểm soát tần suất logic trượt được áp dụng trong trò chơi. Nó bắt đầu từ 0, nghĩa là chưa có bản cập nhật nào xảy ra.
            const int slideUpdateFrequency = 2; //Hằng số này xác định tần suất áp dụng hành động trượt (có thể là sau mỗi 2 lần cập nhật trò chơi). Các hằng số như thế này được sử dụng để tránh các con số ma thuật và giúp mã dễ bảo trì hơn.
            int updatesSinceGravityApplied = 0;//bộ đếm này theo dõi số lượng bản cập nhật đã xảy ra kể từ lần áp dụng trọng lực cuối cùng. Nó được khởi tạo thành 0, nghĩa là trọng lực vẫn chưa được áp dụng trong khung hiện tại.
            const int gravityUpdateFrequency = 1;//Hằng số này chỉ định tần suất áp dụng trọng lực trong trò chơi, trong trường hợp này là mỗi bản cập nhật (hoặc mỗi khung hình). Giống như tần suất trượt, điều này đảm bảo áp dụng trọng lực một cách nhất quán.
            Direction gravity = Direction.None;//Biến này biểu diễn hướng hiện tại của trọng lực, sử dụng enum Direction tùy chỉnh. Ban đầu, nó được đặt thành None, nghĩa là trọng lực có thể không ảnh hưởng đến người chơi. Trong trò chơi, trọng lực thường được áp dụng theo hướng xuống dưới, nhưng trò chơi có thể cho phép trọng lực theo các hướng khác (ví dụ: trái hoặc phải, tùy thuộc vào cơ chế).
            PlayerState playerState = PlayerState.Neutral;//Biến này giữ trạng thái hiện tại của người chơi, sử dụng enum PlayerState tùy chỉnh. Biến này được khởi tạo thành Neutral, nghĩa là người chơi đang ở trạng thái bình thường, không hoạt động. Các trạng thái khác có thể bao gồm nhảy, chạy, trượt, v.v., tùy thuộc vào cơ chế của trò chơi.
            GameState gameState = GameState.Default;//Biến này giữ trạng thái hiện tại của trò chơi bằng cách sử dụng enum GameState tùy chỉnh. Biến này bắt đầu là Default, biểu thị trạng thái ban đầu của trò chơi. Trạng thái này có thể thay đổi khi trò chơi tiến triển (ví dụ: Paused, GameOver, v.v.).
            (int X, int Y) PlayerPosition = GetStartingPlayerPositionFromScore();//Bộ này biểu diễn vị trí hiện tại của người chơi trên trục X và Y. Hàm GetStartingPlayerPositionFromscore() được gọi để khởi tạo vị trí của người chơi dựa trên cấp độ hiện tại. Nó trả về tọa độ bắt đầu, được đặt thành biến PlayerPosition.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(""""""
	                                                                          
	                                                                    ___   
	                      __     __                                      )_)
	    ___   _  _    _   ) )  __) )  _____            _____   _  _    _   _           __  __    ___    _  _    _  _    
	   | _ \ | || |  | | | |  / _ \  |_   _|    o O O |_   _| | || |  | | | |    o O O \ \/ /   /   \  | \| |  | || |    
	   |  _/ | __ |  | |_| | | (_) |   | |     o        | |   | __ |  | |_| |   o       >  <    | - |  | .` |  | __ |   
	  _|_|_  |_||_|   \___/   \___/   _|_|_   TS__[O]  _|_|_  |_||_|   \___/   TS__[O] /_/\_\   |_|_|  |_|\_|  |_||_|    
	_| """ |_|"""""|_|"""""|_|"""""|_|"""""| {======|_|"""""|_|"""""|_|"""""| {======|_|"""""|_|"""""|_|"""""|_|"""""|  
	"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'./o--000'"`-0-0-'"`-0-0-'"`-0-0-'./o--000'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'  
	                            []
	                                                  _   _    ___    _  _  
	                                           o O O | | | |  | __|  | || |
	                                          o      | |_| |  | _|   | __ | 
	                                         TS__[O]  \___/   |___|  |_||_| 
	                                        {======|_|"""""|_|"""""|_|"""""|
	                                       ./o--000'"`-0-0-'"`-0-0-'"`-0-0-' 

	        ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
	       | UEHer di chuyển đến mục tiêu [<> Cơ sở ? <●>] bằng cách sử dụng các phím mũi tên hoặc W, A, S, D. |
	       | UEHer trong quá trình di chuyển đụng phải (X), nghĩa là UEHer phải đi lại từ đầu.                 |
	       | Sử dụng phím [spacebar] để chuyển đổi (#) tường và (~) khoảng trống để vượt qua thử thách.        |
	       |                                                                                                   |
	       | Hãy nhấn phím Enter để bắt đầu cuộc hành trình ngay bây giờ!!                                     |
	       | Nhấn phím Esc để thoát bất kỳ lúc nào.                                                            |
	        ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
	"""""");
            Console.ResetColor();
            Console.CursorVisible = false;
            PressToContinue();
            Console.Clear();

            while (!closeRequested)
            {
                Update();
                if (closeRequested)
                {
                    break;
                }
                Render();
                SleepAfterRender();
            }
            Console.Clear();

            void SleepAfterRender() //Tốc độ di chuyển 
            {
                TimeSpan sleep = TimeSpan.FromSeconds(1d / 20d) - stopwatch.Elapsed;
                if (sleep > TimeSpan.Zero)
                {
                    Thread.Sleep(sleep);
                }
                stopwatch.Restart();
            }

            (int X, int Y) GetStartingPlayerPositionFromScore() //Vị trí bắt đầu của người chơi
            {
                for (int i = 0; i < scores[score].Length; i++)
                {
                    for (int j = 0; j < scores[score][i].Length; j++)
                    {
                        if (scores[score][i][j] is '@')
                        {
                            return (j + 2, i + 1);
                        }
                    }
                }
                throw new Exception($"cơ sở {score} chưa khởi tạo vị trí cho vật chuyển.");
            }

            void Update() //Cập nhật phím bấm vào 
            {
                while (Console.KeyAvailable)
                {
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.W or ConsoleKey.UpArrow:
                            if (gravity is not Direction.Up)
                            {
                                updatesSinceGravityApplied = int.MaxValue;
                                gravity = Direction.Up;
                            }
                            break;
                        case ConsoleKey.A or ConsoleKey.LeftArrow:
                            if (gravity is not Direction.Left)
                            {
                                updatesSinceGravityApplied = int.MaxValue;
                                gravity = Direction.Left;
                            }
                            break;
                        case ConsoleKey.S or ConsoleKey.DownArrow:
                            if (gravity is not Direction.Down)
                            {
                                updatesSinceGravityApplied = int.MaxValue;
                                gravity = Direction.Down;
                            }
                            break;
                        case ConsoleKey.D or ConsoleKey.RightArrow:
                            if (gravity is not Direction.Right)
                            {
                                updatesSinceGravityApplied = int.MaxValue;
                                gravity = Direction.Right;
                            }
                            break;
                        case ConsoleKey.Spacebar:
                            for (int j = 0; j < scores[score].Length; j++)
                            {
                                for (int k = 0; k < scores[score][j].Length; k++)
                                {
                                    switch (scores[score][j][k])
                                    {
                                        case '#': scores[score][j][k] = '~'; break;
                                        case '~': scores[score][j][k] = '#'; break;
                                    }
                                }
                            }
                            break;
                        case ConsoleKey.Escape: closeRequested = true; return;
                    }
                }

                if (updatesSinceGravityApplied >= gravityUpdateFrequency)
                {
                    switch (gravity)
                    {
                        case Direction.Up: velocity.Y--; break;
                        case Direction.Left: velocity.X--; break;
                        case Direction.Down: velocity.Y++; break;
                        case Direction.Right: velocity.X++; break;
                    }
                    updatesSinceGravityApplied = 0;
                }
                else
                {
                    updatesSinceGravityApplied++;
                }

                playerState = PlayerState.Neutral;

                int u = velocity.Y < 0 ? -velocity.Y : 0;
                int l = velocity.X < 0 ? -velocity.X : 0;
                int d = velocity.Y > 0 ? velocity.Y : 0;
                int r = velocity.X > 0 ? velocity.X : 0;

                if (velocity.Y < 0 && (gravity is Direction.Left && WallLeft() || gravity is Direction.Right && WallRight()))
                {
                    playerState |= PlayerState.Sliding | PlayerState.Up | (PlayerState)gravity;
                    if (updatesSinceSlideApplied >= slideUpdateFrequency)
                    {
                        velocity.Y++;
                        updatesSinceSlideApplied = 0;
                    }
                    updatesSinceSlideApplied++;
                }
                else if (velocity.Y > 0 && (gravity is Direction.Left && WallLeft() || gravity is Direction.Right && WallRight()))
                {
                    playerState |= PlayerState.Sliding | PlayerState.Down | (PlayerState)gravity;
                    if (updatesSinceSlideApplied >= slideUpdateFrequency)
                    {
                        velocity.Y--;
                        updatesSinceSlideApplied = 0;
                    }
                    updatesSinceSlideApplied++;
                }
                else if (velocity.X < 0 && (gravity is Direction.Up && WallUp() || gravity is Direction.Down && WallDown()))
                {
                    playerState |= PlayerState.Sliding | PlayerState.Left | (PlayerState)gravity;
                    if (updatesSinceSlideApplied >= slideUpdateFrequency)
                    {
                        velocity.X++;
                        updatesSinceSlideApplied = 0;
                    }
                    updatesSinceSlideApplied++;
                }
                else if (velocity.X > 0 && (gravity is Direction.Up && WallUp() || gravity is Direction.Down && WallDown()))
                {
                    playerState |= PlayerState.Sliding | PlayerState.Right | (PlayerState)gravity;
                    if (updatesSinceSlideApplied >= slideUpdateFrequency)
                    {
                        velocity.X--;
                        updatesSinceSlideApplied = 0;
                    }
                    updatesSinceSlideApplied++;
                }
                else
                {
                    updatesSinceSlideApplied = 0;
                }

                while ((u > 0 || l > 0 || d > 0 || r > 0) && gameState is GameState.Default)
                {
                    if (u > 0)
                    {
                        if (WallUp())
                        {
                            if (u > 1)
                            {
                                if (playerState.HasFlag(PlayerState.Sliding))
                                {
                                    playerState = PlayerState.Neutral;
                                }
                                playerState |= PlayerState.Squash | PlayerState.Up;
                            }
                            velocity.Y = 0;
                            u = 0;
                        }
                        else
                        {
                            PlayerPosition.Y--;
                            u--;
                        }
                    }

                    if (d > 0)
                    {
                        if (WallDown())
                        {
                            if (d > 1)
                            {
                                if (playerState.HasFlag(PlayerState.Sliding))
                                {
                                    playerState = PlayerState.Neutral;
                                }
                                playerState |= PlayerState.Squash | PlayerState.Down;
                            }
                            velocity.Y = 0;
                            d = 0;
                        }
                        else
                        {
                            PlayerPosition.Y++;
                            d--;
                        }
                    }

                    if (l > 0)
                    {
                        if (WallLeft())
                        {
                            if (l > 1)
                            {
                                if (playerState.HasFlag(PlayerState.Sliding))
                                {
                                    playerState = PlayerState.Neutral;
                                }
                                playerState |= PlayerState.Squash | PlayerState.Left;
                            }
                            velocity.X = 0;
                            l = 0;
                        }
                        else
                        {
                            PlayerPosition.X--;
                            l--;
                        }
                    }

                    if (r > 0)
                    {
                        if (WallRight())
                        {
                            if (r > 1)
                            {
                                if (playerState.HasFlag(PlayerState.Sliding))
                                {
                                    playerState = PlayerState.Neutral;
                                }
                                playerState |= PlayerState.Squash | PlayerState.Right;
                            }
                            velocity.X = 0;
                            r = 0;
                        }
                        else
                        {
                            PlayerPosition.X++;
                            r--;
                        }
                    }

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -2; j <= 2; j++)
                        {
                            char c = scores[score][i + PlayerPosition.Y][j + PlayerPosition.X];
                            switch (c)
                            {
                                case 'X': gameState |= GameState.Died; break; //Gặp X sẽ kết thúc 
                                case '●': gameState |= GameState.Won; break; //Gặp ● là đến đích 
                            }
                        }
                    }
                }

                if (gameState.HasFlag(GameState.Died)) //Khi thua
                {
                    string filePath = @"C:\Users\ASUS\source\repos\test test nè he\FIFIFINAL\Wrong.wav";
                    MusicPlayer musicPlayer = new MusicPlayer(filePath);

                    // Phát nhạc chiến thắng trong một luồng mới
                    musicPlayer.PlayMusicInNewThread();
                    Render();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Đã đến giờ vào học nhưng bạn vẫn chưa đến trường.          Nhấn Enter để quay ngược thời gian");
                    Console.ResetColor();
                    MusicManager.PlayMusic("C:\\Users\\ASUS\\source\\repos\\test test nè he\\FIFIFINAL\\BGMround2.wav");

                    PressToContinue();
                    Console.Clear();

                    PlayerPosition = GetStartingPlayerPositionFromScore(); //Cập nhật lại vị trí người chơi
                    gravity = Direction.None;
                    velocity = (0, 0);
                    gameState = GameState.Default;
                }
                else if (gameState.HasFlag(GameState.Won)) // Khi chiến thắng
                {
                    Render();
                    if (score >= scores.Length - 1) //Chiến thắng toàn game 
                    {
                        Console.Clear();
                        //Giao diện thắng toàn game 
                        GiaoDien win = new GiaoDien();
                        win.DisplayPrintWinArt();
                        //Mở lịch sử 
                        GiaoDien lan4 = new GiaoDien();
                        lan4.DisplayLeaderboard();

                        closeRequested = true;
                        return;
                    }
                    string filePath = @"C:\Users\ASUS\source\repos\test test nè he\FIFIFINAL\Correct.wav";
                    MusicPlayer musicPlayer = new MusicPlayer(filePath);

                    // Phát nhạc chiến thắng trong một luồng mới
                    musicPlayer.PlayMusicInNewThread();
                    MusicManager.PlayMusic("C:\\Users\\ASUS\\source\\repos\\test test nè he\\FIFIFINAL\\BGMround2.wav");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Bạn đã chinh phục thành công cơ sở này.                    Nhấn enter để đến cơ sở tiếp theo.");
                    Console.ResetColor();

                    PressToContinue();
                    Console.Clear();
                    score++;
                    PlayerPosition = GetStartingPlayerPositionFromScore();
                    gravity = Direction.None;
                    velocity = (0, 0);
                    gameState = GameState.Default;
                }
            }
            bool WallUp() =>
                scores[score][PlayerPosition.Y - 2][PlayerPosition.X - 2] is '█' or '#' ||
                scores[score][PlayerPosition.Y - 2][PlayerPosition.X - 1] is '█' or '#' ||
                scores[score][PlayerPosition.Y - 2][PlayerPosition.X] is '█' or '#' ||
                scores[score][PlayerPosition.Y - 2][PlayerPosition.X + 1] is '█' or '#' ||
                scores[score][PlayerPosition.Y - 2][PlayerPosition.X + 2] is '█' or '#';
            bool WallDown() =>
                scores[score][PlayerPosition.Y + 2][PlayerPosition.X - 2] is '█' or '#' ||
                scores[score][PlayerPosition.Y + 2][PlayerPosition.X - 1] is '█' or '#' ||
                scores[score][PlayerPosition.Y + 2][PlayerPosition.X] is '█' or '#' ||
                scores[score][PlayerPosition.Y + 2][PlayerPosition.X + 1] is '█' or '#' ||
                scores[score][PlayerPosition.Y + 2][PlayerPosition.X + 2] is '█' or '#';
            bool WallLeft() =>
                scores[score][PlayerPosition.Y - 1][PlayerPosition.X - 3] is '█' or '#' ||
                scores[score][PlayerPosition.Y][PlayerPosition.X - 3] is '█' or '#' ||
                scores[score][PlayerPosition.Y + 1][PlayerPosition.X - 3] is '█' or '#';
            bool WallRight() =>
                scores[score][PlayerPosition.Y - 1][PlayerPosition.X + 3] is '█' or '#' ||
                scores[score][PlayerPosition.Y][PlayerPosition.X + 3] is '█' or '#' ||
                scores[score][PlayerPosition.Y + 1][PlayerPosition.X + 3] is '█' or '#';

            void Render()
            {
                string[] playerSprite = RenderPlayerState();
                StringBuilder render = new();
                render.AppendLine();
                for (int i = 0; i < scores[score].Length; i++)
                {
                    render.Append(' ');
                    render.Append(' ');
                    for (int j = 0; j < scores[score][i].Length; j++)
                    {
                        char c = scores[score][i][j];
                        if (c is '@')
                        {
                            c = ' ';
                        }
                        if (c is not 'X' and not '●' &&
                            PlayerPosition.X - 2 <= j &&
                            PlayerPosition.X + 2 >= j &&
                            PlayerPosition.Y - 1 <= i &&
                            PlayerPosition.Y + 1 >= i)
                        {
                            c = playerSprite[i - PlayerPosition.Y + 1][j - PlayerPosition.X + 2];
                        }
                        render.Append(c);
                    }
                    render.AppendLine();
                }
                render.AppendLine();
                render.AppendLine($"Bạn đã chạy đến được {score} cơ sở                               Hướng đi của UEHer {RenderGravityIdentifier()}");
                Console.SetCursorPosition(0, 0);
                Console.Write(render);
                Console.CursorVisible = false;
            }


            string[] RenderPlayerState() //Hình dáng của vật di chuyển dựa vào phím bấm vào đầu vào 
            {
                return (playerState) switch
                {
                    (PlayerState.Sliding | PlayerState.Up | PlayerState.Right) or
                    (PlayerState.Sliding | PlayerState.Down | PlayerState.Left) =>
                        [
                            "╭──╮ ",
                            "╰╮ ╰╮",
                            " ╰──╯",
                        ],
                    (PlayerState.Sliding | PlayerState.Down | PlayerState.Right) or
                    (PlayerState.Sliding | PlayerState.Up | PlayerState.Left) =>
                        [
                            " ╭──╮",
                            "╭╯ ╭╯",
                            "╰──╯ ",
                        ],
                    (PlayerState.Squash | PlayerState.Up | PlayerState.Right) =>
                        [
                            "╭───╮",
                            "╰─╮ │",
                            "  ╰─╯",
            ],
                    (PlayerState.Squash | PlayerState.Down | PlayerState.Right) =>
                        [
                            "  ╭─╮",
                            "╭─╯ │",
                            "╰───╯",
            ],
                    (PlayerState.Squash | PlayerState.Up | PlayerState.Left) =>
                        [
                            "╭───╮",
                            "│ ╭─╯",
                            "╰─╯  ",
            ],
                    (PlayerState.Squash | PlayerState.Down | PlayerState.Left) =>
                        [
                            "╭─╮  ",
                            "│ ╰─╮",
                            "╰───╯",
            ],
                    (PlayerState.Squash | PlayerState.Up) =>
                        [
                            "╭───╮",
                            "╰───╯",
                            "     ",
            ],
                    (PlayerState.Squash | PlayerState.Down) =>
                        [
                            "     ",
                            "╭───╮",
                            "╰───╯",
            ],
                    (PlayerState.Squash | PlayerState.Right) =>
                        [
                            "  ╭─╮",
                            "  │ │",
                            "  ╰─╯",
            ],
                    (PlayerState.Squash | PlayerState.Left) =>
                        [
                            "╭─╮  ",
                            "│ │  ",
                            "╰─╯  ",
            ],
                    _ =>
                        [
                            "╭───╮",
                            "│   │",
                            "╰───╯",
            ],
                };
            }

            char RenderGravityIdentifier() //In ra hướng di chuyển 
            {
                return gravity switch
                {
                    Direction.None => '○',
                    Direction.Up => '^',
                    Direction.Down => 'v',
                    Direction.Left => '<',
                    Direction.Right => '>',
                    _ => throw new NotImplementedException(),
                };
            }

            void PressToContinue(ConsoleKey key = ConsoleKey.Enter) //Nhấn phím Enter để tiếp tục 
            {
                ConsoleKey input = default;
                while (input != key && !closeRequested)
                {
                    input = Console.ReadKey(true).Key;
                    if (input is ConsoleKey.Escape)
                    {
                        closeRequested = true;
                        return;
                    }
                }
            }
        }

        internal enum Direction
        {
            None = 0,
            Up = 1 << 0,
            Down = 1 << 1,
            Left = 1 << 2,
            Right = 1 << 3,
        }

        internal enum GameState
        {
            Default = 0,
            Died = 1 << 0,
            Won = 1 << 1,
        }

        internal enum PlayerState
        {
            Neutral = 0,
            Up = 1 << 0,
            Down = 1 << 1,
            Left = 1 << 2,
            Right = 1 << 3,
            Sliding = 1 << 4,
            Squash = 1 << 5,
        }
    }
}
