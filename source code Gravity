using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

// Vẽ các level trong game
char[][][] levels =
[
	// '@': vị trí bắt đầu của người chơi
	// ' ': không gian trống
	// '~': không gian có thể chuyển đổi thành tường
	// '█': tường
	// '#': tường có thể chuyển đổi thành không gian
	// 'X': gai chết
	// '●': đích đến

  // level 1
	[
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                    ●          █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█      @@@@@                                                    █".ToCharArray(),
		"█      @@@@@                                                    █".ToCharArray(),
		"█      @@@@@                                                    █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
	],

  // level 2
	[
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
		"█                                             █                 █".ToCharArray(),
		"█                                             █                 █".ToCharArray(),
		"█                                             █                 █".ToCharArray(),
		"█                                             █                 █".ToCharArray(),
		"█                                             █        ●        █".ToCharArray(),
		"█                                             █                 █".ToCharArray(),
		"█                                             █                 █".ToCharArray(),
		"█                 █                           █                 █".ToCharArray(),
		"█                 █                           █                 █".ToCharArray(),
		"█                 █                           █                 █".ToCharArray(),
		"█                 █                           █                 █".ToCharArray(),
		"█                 █                           █                 █".ToCharArray(),
		"█                 █                                             █".ToCharArray(),
		"█      @@@@@      █                                             █".ToCharArray(),
		"█      @@@@@      █                                             █".ToCharArray(),
		"█      @@@@@      █                                             █".ToCharArray(),
		"█                 █                                             █".ToCharArray(),
		"█                 █                                             █".ToCharArray(),
		"█                 █                                             █".ToCharArray(),
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
	],

  // level 3
	[
		"                  ███████████                   ".ToCharArray(),
		"              ████           █████              ".ToCharArray(),
		"          ████                    ████          ".ToCharArray(),
		"       ███                            ███       ".ToCharArray(),
		"     ██                                  ██     ".ToCharArray(),
		"    █                                      █    ".ToCharArray(),
		"   █                                        █   ".ToCharArray(),
		"  █                                          █  ".ToCharArray(),
		" █                          █                 █ ".ToCharArray(),
		"█                           █                  █".ToCharArray(),
		"█                           █                  █".ToCharArray(),
		"█                         ██                   █".ToCharArray(),
		"█                       ██                     █".ToCharArray(),
		"█         ●           ██                       █".ToCharArray(),
		" █                  ██                        █ ".ToCharArray(),
		"  █               ██                         █  ".ToCharArray(),
		"   █             █                          █   ".ToCharArray(),
		"    █            █                         █    ".ToCharArray(),
		"     ██          █                       ██     ".ToCharArray(),
		"       ███       █   @@@@@            ███       ".ToCharArray(),
		"          ████   █   @@@@@        ████          ".ToCharArray(),
		"              ████   @@@@@   █████              ".ToCharArray(),
		"                  ███████████                   ".ToCharArray(),
	],

  // level 4
	[
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
		"█XXXXXXX                                                        █".ToCharArray(),
		"█XXXXXXX                                                        █".ToCharArray(),
		"█XXXXXXX                                                        █".ToCharArray(),
		"█XXXXXXX          █XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX          █".ToCharArray(),
		"█XXXXXXX          █         ●                                   █".ToCharArray(),
		"█XXXXXXX          █                                             █".ToCharArray(),
		"█XXXXXXX          █                                             █".ToCharArray(),
		"█XXXXXXX          █                                             █".ToCharArray(),
		"█XXXXXX█          █                                             █".ToCharArray(),
		"████████          ███████████████████████████████████████████████".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█                                                               █".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█          █XXXXXXXXXXX█".ToCharArray(),
		"██████████████████████████████████████████          █████████████".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█          █XXXXXXXXXXX█".ToCharArray(),
		"█    @@@@@                                                      █".ToCharArray(),
		"█    @@@@@                                                      █".ToCharArray(),
		"█    @@@@@                                                      █".ToCharArray(),
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
	],

  // level 5
	[
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█                                                              X█".ToCharArray(),
		"█                                                              X█".ToCharArray(),
		"█                                                              X█".ToCharArray(),
		"█                                                     ●        X█".ToCharArray(),
		"█                                                              X█".ToCharArray(),
		"█                                                              X█".ToCharArray(),
		"█                                                              X█".ToCharArray(),
		"█                                                              X█".ToCharArray(),
		"█                                                              X█".ToCharArray(),
		"█                                                              X█".ToCharArray(),
		"█                                                              X█".ToCharArray(),
		"█                                                              X█".ToCharArray(),
		"█      @@@@@                                                   X█".ToCharArray(),
		"█      @@@@@                                                   X█".ToCharArray(),
		"█      @@@@@                                                   X█".ToCharArray(),
		"█                                                              X█".ToCharArray(),
		"█                                                              X█".ToCharArray(),
		"█                                                              X█".ToCharArray(),
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
	],

  // level 6
	[
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                    ●        X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X     @@@@@                                                   X█".ToCharArray(),
		"█X     @@@@@                                                   X█".ToCharArray(),
		"█X     @@@@@                                                   X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
	],

   // level 7
	[
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX                        X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX                        X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX                        X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX               ●        X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX                        X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX                        X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX                        X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX                        X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX                        X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X     @@@@@                                                   X█".ToCharArray(),
		"█X     @@@@@                                                   X█".ToCharArray(),
		"█X     @@@@@                                                   X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
	],

  // level 8
	[
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                    ●        X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                        XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X                        XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X                        XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X                        XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X     @@@@@              XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X     @@@@@              XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X     @@@@@              XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X                        XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X                        XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
	],

  // level 9
	[
		"██████████████████████████████████████████████".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXX                  X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXX                    X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXX                      X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXX             ●          X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXX                          X█".ToCharArray(),
		"█XXXXXXXXXXXXXXX                          XXX█".ToCharArray(),
		"█XXXXXXXXXXXXX                          XXXXX█".ToCharArray(),
		"█XXXXXXXXXXX                          XXXXXXX█".ToCharArray(),
		"█XXXXXXXXX                          XXXXXXXXX█".ToCharArray(),
		"█XXXXXXX                          XXXXXXXXXXX█".ToCharArray(),
		"█XXXXX                          XXXXXXXXXXXXX█".ToCharArray(),
		"█XXX                          XXXXXXXXXXXXXXX█".ToCharArray(),
		"█X                          XXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X                        XXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X                      XXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X@@@@@               XXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X@@@@@             XXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X@@@@@           XXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"██████████████████████████████████████████████".ToCharArray(),
	],

   // level 10
	[
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X                                         X                   X█".ToCharArray(),
		"█X                                         X                   X█".ToCharArray(),
		"█X                                         X                   X█".ToCharArray(),
		"█X                                         X         ●         X█".ToCharArray(),
		"█X                                         X                   X█".ToCharArray(),
		"█X                                         X                   X█".ToCharArray(),
		"█X                                         X                   X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                   X                                         X█".ToCharArray(),
		"█X                   X                                         X█".ToCharArray(),
		"█X       @@@@@       X                                         X█".ToCharArray(),
		"█X       @@@@@       X                                         X█".ToCharArray(),
		"█X       @@@@@       X                                         X█".ToCharArray(),
		"█X                   X                                         X█".ToCharArray(),
		"█X                   X                                         X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
	],

  // level 11
	[
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
		"█                                             #                 █".ToCharArray(),
		"█                                             #                 █".ToCharArray(),
		"█                                             #                 █".ToCharArray(),
		"█                                             #                 █".ToCharArray(),
		"█                                             #                 █".ToCharArray(),
		"█                                             #                 █".ToCharArray(),
		"█                                             #                 █".ToCharArray(),
		"█                                             █~~~~~~~~~~~~~~~~~█".ToCharArray(),
		"█                                             █                 █".ToCharArray(),
		"█                                             █                 █".ToCharArray(),
		"█                                             █                 █".ToCharArray(),
		"█                                             █                 █".ToCharArray(),
		"█                                             █                 █".ToCharArray(),
		"█      @@@@@                                  █                 █".ToCharArray(),
		"█      @@@@@                                  █                 █".ToCharArray(),
		"█      @@@@@                                  █                 █".ToCharArray(),
		"█                                             █                 █".ToCharArray(),
		"█                                             █        ●        █".ToCharArray(),
		"█                                             █                 █".ToCharArray(),
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
	],

  // level 12
	[
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X##############################################################█".ToCharArray(),
		"█X~                                                             █".ToCharArray(),
		"█X~                                                             █".ToCharArray(),
		"█X~                                                             █".ToCharArray(),
		"█X~         █                                                   █".ToCharArray(),
		"█X~         █                                                   █".ToCharArray(),
		"█X~         █                                                   █".ToCharArray(),
		"█X~         █                                                   █".ToCharArray(),
		"█X~         █                                                   █".ToCharArray(),
		"█X~         █                                                   █".ToCharArray(),
		"█X~    ●    █                                                   █".ToCharArray(),
		"█X~         █                                                   █".ToCharArray(),
		"█X~         █                                                   █".ToCharArray(),
		"█████████████████████████████████████████████████             ███".ToCharArray(),
		"█                                               #             ~X█".ToCharArray(),
		"█      @@@@@                                    #             ~X█".ToCharArray(),
		"█      @@@@@                                    #             ~X█".ToCharArray(),
		"█      @@@@@                                    #             ~X█".ToCharArray(),
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
	],

  // level 13
	[
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                            #########        X█".ToCharArray(),
		"█X                                                    ~        X█".ToCharArray(),
		"█X                                                    ~        X█".ToCharArray(),
		"█X     #####                                          ~        X█".ToCharArray(),
		"█X     # ● #                                          ~        X█".ToCharArray(),
		"█X     #####                                          ~        X█".ToCharArray(),
		"█X                                                    ~        X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXX                             ~        X█".ToCharArray(),
		"█X                                                    ~        X█".ToCharArray(),
		"█X                                                    ~        X█".ToCharArray(),
		"█X                                                    ~        X█".ToCharArray(),
		"█X     @@@@@                                          ~        X█".ToCharArray(),
		"█X     @@@@@                                          ~        X█".ToCharArray(),
		"█X     @@@@@                                                   X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█X                                                             X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█████████████████████████████████████████████████████████████████".ToCharArray(),
	],

  // level 14
	[
		"█████████████████████████████████████████████████████████".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█XXXXXXXXXX#####XXXXXXXXX#####XXXXXXXXX#####XXXXXXXXXXXX█".ToCharArray(),
		"█XXXXXXXXXX            ~X            #X               XX█".ToCharArray(),
		"█XXXXXXXXXX            ~X            #X             ● XX█".ToCharArray(),
		"█XXXXXXXXXX                                           XX█".ToCharArray(),
		"█X@@@@@         ~X            ~X            ~XXXXXXXXXXX█".ToCharArray(),
		"█X@@@@@         ~X            ~X            ~XXXXXXXXXXX█".ToCharArray(),
		"█X@@@@@         ~X#####XXXXXXXXX~~~~~XXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█████████████████████████████████████████████████████████".ToCharArray(),
	],

  // level 15
	[
		"██████████████████████████████████████████████████████████████████████".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X@@@@@              XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X@@@@@                         XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X@@@@@                                   XXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X                                                 XXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"█X        ~~~~~~~~~                                        XXXXXXXXXX█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXX##########                                   XXXX█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX~~~~~~~~~                          XXX█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX########                  XX█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX~~~~~~~~          X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX      ●  X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX        X█".ToCharArray(),
		"█XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX█".ToCharArray(),
		"██████████████████████████████████████████████████████████████████████".ToCharArray(),
	],
];

// mã hóa đầu ra có thể hiển thị ký tự unicode
Console.OutputEncoding = Encoding.UTF8;

// Khởi tạo một đồng hồ bấm giờ và bắt đầu tính thời gian ngay lập tức để theo dõi thời gian chương trình.
Stopwatch stopwatch = Stopwatch.StartNew();

// kiểm tra nếu người dùng yêu cầu thoát khỏi chương trình 
bool closeRequested = false;

// Tạo biến velocity (vận tốc) của người chơi với tọa độ X và Y ban đầu là 0
(int X, int Y) velocity = (0, 0);

// Khởi tạo biến level với giá trị mặc định là 0
int level = 0;

// Đếm số lần cập nhật (update) kể từ khi “trượt” (slide) được áp dụng lần cuối 
int updatesSinceSlideApplied = 0;

// Đặt tần suất (frequency) cập nhật áp dụng hiệu ứng trượt là 2 lần 
const int slideUpdateFrequency = 2;

// Đếm số lần cập nhật kể từ khi tác dụng “trọng lực” (gravity) được áp dụng lần cuối
int updatesSinceGravityApplied = 0;

// Đặt tần suất cập nhật khi áp dụng trọng lực là 1 lần 
const int gravityUpdateFrequency = 1;

// Thiết lập hướng trọng lực (gravity) mặc định là None, chưa áp dụng trọng lực theo bất kỳ hướng nào
Direction gravity = Direction.None;

//Khởi tạo trạng thái của người chơi (player) là Neutral (trạng thái trung lập)
PlayerState playerState = PlayerState.Neutral;

//Khởi tạo trạng thái trò chơi (game) là Default (mặc định)
GameState gameState = GameState.Default;

//Đặt vị trí ban đầu của người chơi (PlayerPosition) dựa trên cấp độ hiện tại bằng cách gọi hàm GetStartingPlayerPositionFromLevel()
(int X, int Y) PlayerPosition = GetStartingPlayerPositionFromLevel();


// in giao diện
Console.Write("""

	     ██████╗ ██████╗  █████╗ ██╗   ██╗██╗████████╗██╗   ██╗
	    ██╔════╝ ██╔══██╗██╔══██╗██║   ██║██║╚══██╔══╝╚██╗ ██╔╝
	    ██║  ███╗██████╔╝███████║██║   ██║██║   ██║    ╚████╔╝ 
	    ██║   ██║██╔══██╗██╔══██║╚██╗ ██╔╝██║   ██║     ╚██╔╝  
	    ╚██████╔╝██║  ██║██║  ██║ ╚████╔╝ ██║   ██║      ██║   
	     ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝  ╚═══╝  ╚═╝   ╚═╝      ╚═╝   

	    Reach the goal (●) by using the [arrow keys] or [WASD] to
	    manipulate gravity. Watch out for spikes (X). Use the
	    [spacebar] to toggle (#) walls and (~) spaces.

	    Press [escape] to close the game at any time.

	    Press [enter] to begin...
	""");

// ẩn con trỏ nhấp nháy
Console.CursorVisible = false;
// nhấn để tiếp tục
PressToContinue();
// xóa màn hình sau khi thao tác
Console.Clear();

// Vòng lặp while kiểm tra xem người dùng có yêu cầu thoát chương trình hay chưa
while (!closeRequested)
{
// Gọi hàm Update() để cập nhật vị trí, trạng thái người chơi
	Update();
// Kiểm tra lại xem biến closeRequested đã chuyển thành true hay chưa
	if (closeRequested)
	{
// Nếu true, chương trình thoát khỏi vòng lặp while
		break;
	}
  // Gọi hàm Render() để vẽ hoặc cập nhật giao diện người dùng, hiển thị trạng thái hiện tại của trò chơi
  Render();
  // Gọi hàm SleepAfterRender() để tạm dừng chương trình trong một thời gian ngắn sau mỗi lần hiển thị
	SleepAfterRender();
}
// xóa chương trình sau khi thao tác
Console.Clear();

// Hàm tạo khoảng dừng ngắn sau hiển thị
void SleepAfterRender()
{
  /* Tính thời gian ngủ (sleep time) cần thiết để đạt tốc độ khung hình (frame rate) mong muốn
  Sau đó, lấy khoảng thời gian này trừ đi thời gian đã trôi qua từ lần stopwatch bắt đầu, để tính ra thời gian còn lại cần ngủ */
	TimeSpan sleep = TimeSpan.FromSeconds(1d / 20d) - stopwatch.Elapsed;

  // Kiểm tra nếu thời gian ngủ sleep lớn hơn 0, đảm bảo chương trình chỉ ngủ khi còn thời gian dư
	if (sleep > TimeSpan.Zero)
	{
    // Gọi Thread.Sleep(sleep) để tạm dừng thực thi chương trình trong khoảng thời gian sleep
		Thread.Sleep(sleep);
	}
  // Khởi động lại stopwatch để bắt đầu tính thời gian cho chu kỳ vòng lặp tiếp theo
	stopwatch.Restart();
}

// hàm trả về vị trí khởi đầu của người chơi trong cấp độ hiện tại
(int X, int Y) GetStartingPlayerPositionFromLevel()
{
  // Vòng lặp ngoài, lặp qua từng hàng (i) trong cấp độ hiện tại (levels[level])
	for (int i = 0; i < levels[level].Length; i++)
	{
    // Vòng lặp trong, lặp qua từng cột (j) trong hàng hiện tại (levels[level][i])
		for (int j = 0; j < levels[level][i].Length; j++)
		{
      // Kiểm tra nếu ký tự ở vị trí (i, j) trong cấp độ hiện tại là '@' (vị trí bắt đầu của người chơi)
			if (levels[level][i][j] is '@')
			{
        // Nếu tìm thấy ký tự '@', trả về tọa độ của vị trí khởi đầu
				return (j + 2, i + 1);
			}
		}
	}
  // Nếu không tìm thấy ký tự '@', ném ra ngoại lệ với thông báo lỗi: cấp độ hiện tại không có vị trí khởi đầu cho người chơi
	throw new Exception($"Level {level} has no starting position.");
}

// Hàm cập nhật trạng thái
void Update()
{
  // Kiểm tra các phím bấm của người dùng. Nếu có, vòng lặp tiếp tục xử lý từng phím
	while (Console.KeyAvailable)
	{
    // Nhận phím từ người dùng và xác định hành động tương ứng
		switch (Console.ReadKey(true).Key)
		{
      // Nếu là phím W hoặc ↑
			case ConsoleKey.W or ConsoleKey.UpArrow:
        // Nếu trọng lực khoonng phải hướng đi lên
				if (gravity is not Direction.Up)
				{
          // Áp dụng trọng lực theo hướng phím đã bấm ngay lập tức
					updatesSinceGravityApplied = int.MaxValue;
          // Trọng lực đi lên
					gravity = Direction.Up;
				}
				break;

      /* Tương tự, nếu nhập phím A hoặc ← mà trong lực không theo hướng qua trái
      thì ngay lập tức áp dụng trọng lực hướng qua trái và thoát vòng lặp */
			case ConsoleKey.A or ConsoleKey.LeftArrow:
				if (gravity is not Direction.Left)
				{
					updatesSinceGravityApplied = int.MaxValue;
					gravity = Direction.Left;
				}
				break;

      /* Nếu nhập phím S hoặc ↓ mà trong lực không theo hướng đi xuống
      thì ngay lập tức áp dụng trọng lực hướng đi xuống và thoát vòng lặp */
			case ConsoleKey.S or ConsoleKey.DownArrow:
				if (gravity is not Direction.Down)
				{
					updatesSinceGravityApplied = int.MaxValue;
					gravity = Direction.Down;
				}
				break;

      /* Nếu nhập phím D hoặc → mà trong lực không theo hướng qua phải
      thì ngay lập tức áp dụng trọng lực hướng qua phải và thoát vòng lặp */
			case ConsoleKey.D or ConsoleKey.RightArrow:
				if (gravity is not Direction.Right)
				{
					updatesSinceGravityApplied = int.MaxValue;
					gravity = Direction.Right;
				}
				break;

      // ConsoleKey.Spacebar thay đổi các ký tự # và ~ trong cấp độ hiện tại (levels[level])
			case ConsoleKey.Spacebar:
				for (int j = 0; j < levels[level].Length; j++)
				{
					for (int k = 0; k < levels[level][j].Length; k++)
					{
						switch (levels[level][j][k])
						{
							case '#': levels[level][j][k] = '~'; break;
							case '~': levels[level][j][k] = '#'; break;
						}
					}
				}
				break;

      // ConsoleKey.Escape đặt closeRequested là true để thoát chương trình khi nhấn phím Esc
			case ConsoleKey.Escape: closeRequested = true; return;
		}
	}

  /* Nếu số lần cập nhật đã vượt quá tần suất cập nhật trọng lực (gravityUpdateFrequency), 
  trọng lực sẽ ảnh hưởng đến tốc độ (velocity) của người chơi */
	if (updatesSinceGravityApplied >= gravityUpdateFrequency)
	{
		switch (gravity)
		{
      // Giảm vận tốc khi đi lên
			case Direction.Up:    velocity.Y--; break;
      // Giảm vận tốc khi sang trái
			case Direction.Left:  velocity.X--; break;
      // Tăng vận tốc khi đi xuống
			case Direction.Down:  velocity.Y++; break;
      // Tăng vận tốc khi sang phải
			case Direction.Right: velocity.X++; break;
		}
		updatesSinceGravityApplied = 0;
	}
	else
	{
		updatesSinceGravityApplied++;
	}

  // Đặt trạng thái người chơi là Neutral trước khi xử lý các thay đổi trạng thái trong mỗi khung hình (frame)
	playerState = PlayerState.Neutral;

  // // Xác định số lần di chuyển trong các hướng dựa trên vận tốc hiện tại
	int u = velocity.Y < 0 ? -velocity.Y : 0;
	int l = velocity.X < 0 ? -velocity.X : 0;
	int d = velocity.Y > 0 ?  velocity.Y : 0;
	int r = velocity.X > 0 ?  velocity.X : 0;

  // Xử lý va chạm với tường. Nếu có va chạm, cập nhật trạng thái người chơi và điều chỉnh vận độ
  // Nếu velocity.Y < 0 (đang di chuyển lên) và có va chạm với tường bên trái hoặc bên phải dựa vào hướng trọng lực (gravity)
	if (velocity.Y < 0 && (gravity is Direction.Left && WallLeft() || gravity is Direction.Right && WallRight()))
	{
    // Nếu có va chạm, cập nhật trạng thái nhân vật thành Sliding, Up, và trọng lực hiện tại
		playerState |= PlayerState.Sliding | PlayerState.Up | (PlayerState)gravity;

    /* Nếu số lần cập nhật (updatesSinceSlideApplied) đạt đến tần suất trượt (slideUpdateFrequency), 
     tăng velocity.Y để mô phỏng hiệu ứng trượt lên */
		if (updatesSinceSlideApplied >= slideUpdateFrequency)
		{
			velocity.Y++;
			updatesSinceSlideApplied = 0;
		}
		updatesSinceSlideApplied++;
	}

  // Tương tự với di chuyển xuống và có va chạm với tường trái hoặc phải, xử lý vận độ để tạo hiệu ứng trượt xuống
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

  // Di chuyển sang trái và có va chạm với tường trên hoặc dưới, xử lý vận tốc để tạo hiệu ứng trượt sang trái
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

  // Di chuyển sang phải và có va chạm với tường trên hoặc dưới, xử lý vận tốc để tạo hiệu ứng trượt sang phải
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

  // Nếu không có va chạm, đặt lại biến bằng 0
	else
	{
		updatesSinceSlideApplied = 0;
	}


  /* Vòng lặp sẽ tiếp tục chạy miễn là có ít nhất một trong các biến u, d, l, hoặc r lớn hơn 0, 
  và trạng thái trò chơi là GameState.Default */
	while ((u > 0 || l > 0 || d > 0 || r > 0) && gameState is GameState.Default)
	{
    // Nếu u lớn hơn 0
		if (u > 0)
		{
      // Kiểm tra xem có va chạm với tường trên không
			if (WallUp())
			{
				if (u > 1)
				{
          // Kiểm tra nếu nhân vật đang trượt (Sliding), thì đặt trạng thái nhân vật về Neutral
					if (playerState.HasFlag(PlayerState.Sliding))
					{
						playerState = PlayerState.Neutral;
					}
          // Cập nhật trạng thái nhân vật thành Squash và Up để mô phỏng hiệu ứng nén (squash) khi va chạm
					playerState |= PlayerState.Squash | PlayerState.Up;
				}
        Đặt velocity.Y về 0 để ngăn chặn di chuyển lên tiếp và đặt u về 0 để dừng lệnh di chuyển lên
				velocity.Y = 0;
				u = 0;
			}
			else
			{
        // Nếu không có va chạm, giảm PlayerPosition.Y và u để mô phỏng di chuyển lên
				PlayerPosition.Y--;
				u--;
			}
		}

    // Tương tự như di chuyển lên, nhưng kiểm tra va chạm với tường dưới 
		if (d > 0)
		{
			if (WallDown())
			{
        // Nếu có va chạm, cập nhật trạng thái nhân vật và ngăn chặn di chuyển xuống tiếp
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
      // Nếu không có va chạm, tăng PlayerPosition.Y và d để mô phỏng di chuyển xuống
			else
			{
				PlayerPosition.Y++;
				d--;
			}
		}

    // Kiểm tra va chạm với tường trái 
		if (l > 0)
		{
			if (WallLeft())
			{
        // Cập nhật trạng thái và ngăn chặn di chuyển sang trái nếu có va chạm
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
      // Nếu không có va chạm, giảm PlayerPosition.X và l
			else
			{
				PlayerPosition.X--;
				l--;
			}
		}

    // Kiểm tra va chạm với tường phải
		if (r > 0)
		{
			if (WallRight())
			{
        // Nếu có va chạm, cập nhật trạng thái và ngăn chặn di chuyển sang phải tiếp
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
      // Nếu không có va chạm, tăng PlayerPosition.X và r
			else
			{
				PlayerPosition.X++;
				r--;
			}
		}

    /* Vòng lặp ngoài lặp từ -1 đến 1, kiểm tra hàng xung quanh vị trí Y của nhân vật 
    (một hàng phía trên, một hàng hiện tại, và một hàng phía dưới) */
		for (int i = -1; i <= 1; i++)
		{
      /* Vòng lặp trong lặp từ -2 đến 2, kiểm tra cột xung quanh vị trí X của nhân vật
      (hai cột bên trái, một cột bên trái, cột hiện tại, một cột bên phải, và hai cột bên phải) */
			for (int j = -2; j <= 2; j++)
			{
        /* Xác định ký tự tại vị trí của nhân vật bằng cách cộng thêm các giá trị i và j 
        vào vị trí hiện tại của PlayerPosition */
				char c = levels[level][i + PlayerPosition.Y][j + PlayerPosition.X];

        // Kiểm tra ký tự c để xác định trạng thái của trò chơi
				switch (c)
				{
          // Nếu ký tự là 'X', đây là gai chết. Cập nhật trạng thái đã chết
					case 'X': gameState |= GameState.Died; break;
          // Nếu ký tự là '●', đây là đích đến. Cập nhật trạng tahsi chiền thắng
					case '●': gameState |= GameState.Won; break;
				}
			}
		}
	}

  /* Kiểm tra xem trạng thái trò chơi có bao gồm cờ Died hay không.
   Nếu có, điều này có nghĩa là người chơi đã chết */
	if (gameState.HasFlag(GameState.Died))
	{
    // Gọi hàm Render() để cập nhật màn hình với trạng thái hiện tại của trò chơi
		Render();

    // In thông báo cho người chơi họ đã chết và cần nhấn Enter để thử lại
		Console.WriteLine("You died. Press enter to retry level.");

    // Chờ người chơi nhấn Enter
		PressToContinue();

    // Đặt lại vị trí của người chơi về vị trí bắt đầu của cấp độ hiện tại
		PlayerPosition = GetStartingPlayerPositionFromLevel();

    // Đặt lại trọng lực về None (không có trọng lực)
		gravity = Direction.None;

    // Đặt lại vận tốc của nhân vật về 0
		velocity = (0, 0);

    // Đặt lại trạng thái trò chơi về mặc định
		gameState = GameState.Default;
	}

  // Nếu trạng thái trò chơi có bao gồm cờ Won, người chơi thắng
	else if (gameState.HasFlag(GameState.Won))
	{
    //  Cập nhật màn hình với trạng thái hiện tại
		Render();

    // Kiểm tra xem cấp độ hiện tại có phải là level cuối cùng hay không
		if (level >= levels.Length - 1)
		{
      // Nếu là level cuối, in thông báo chúc mừng người chơi chiến thắng tất cả các level
			Console.WriteLine("You Won. You beat all the levels! Congratulations!");
      // Nhấn Enter để thoát game
			Console.WriteLine("Press enter to exit game...");
      // Chờ người chơi nhấn Enter
			PressToContinue();
      // Đặt yêu cầu đóng trò chơi về true để thoát
			closeRequested = true;

      // Kết thúc hàm hiện tại, không thực hiện bất kỳ hành động nào khác
			return;
		}
    // Nếu không pahir là màn cuối, thông báo chiến thắng level hiện tại và nhấn Enter để chuyển sang level mới
		Console.WriteLine("You Won. Press enter to move to the next level.");
		PressToContinue();
    // Xóa màn hình level vừa thắng
		Console.Clear();
    // Tăng level
		level++;
    // Đặt vị trí m=của người chơi ở level mới
		PlayerPosition = GetStartingPlayerPositionFromLevel();
    // Đặt lại trọng lực bằng 0
		gravity = Direction.None;
    // Đặt vận tốc bằng 0
		velocity = (0, 0);
    // Đặt trạng thái trò chơi về mặc định
		gameState = GameState.Default;
	}
}

/* Kiểm tra các vị trí trong phạm vi phía trên người chơi.
Nếu bất kỳ vị trí nào trong vùng [Y - 2, X - 2] đến [Y - 2, X + 2] có chứa '█' hoặc '#', hàm trả về true
Có tường ở phía trên */
bool WallUp() =>
	levels[level][PlayerPosition.Y - 2][PlayerPosition.X - 2] is '█' or '#' ||
	levels[level][PlayerPosition.Y - 2][PlayerPosition.X - 1] is '█' or '#' ||
	levels[level][PlayerPosition.Y - 2][PlayerPosition.X]     is '█' or '#' ||
	levels[level][PlayerPosition.Y - 2][PlayerPosition.X + 1] is '█' or '#' ||
	levels[level][PlayerPosition.Y - 2][PlayerPosition.X + 2] is '█' or '#';

/* Kiểm tra các vị trí trong phạm vi phía dưới người chơi.
Nếu bất kỳ vị trí nào trong vùng [Y + 2, X - 2] đến [Y + 2, X + 2] có chứa '█' hoặc '#', hàm trả về true
Có tường ở phía dưới */
bool WallDown() =>
	levels[level][PlayerPosition.Y + 2][PlayerPosition.X - 2] is '█' or '#' ||
	levels[level][PlayerPosition.Y + 2][PlayerPosition.X - 1] is '█' or '#' ||
	levels[level][PlayerPosition.Y + 2][PlayerPosition.X]     is '█' or '#' ||
	levels[level][PlayerPosition.Y + 2][PlayerPosition.X + 1] is '█' or '#' ||
	levels[level][PlayerPosition.Y + 2][PlayerPosition.X + 2] is '█' or '#';

/* Kiểm tra các vị trí ở phía bên trái người chơi.
Nếu bất kỳ vị trí nào trong vùng [Y - 1, X - 3] đến [Y + 1, X - 3] có chứa '█' hoặc '#', hàm trả về true
Có tường ở bên trái */
bool WallLeft() =>
	levels[level][PlayerPosition.Y - 1][PlayerPosition.X - 3] is '█' or '#' ||
	levels[level][PlayerPosition.Y][PlayerPosition.X - 3]     is '█' or '#' ||
	levels[level][PlayerPosition.Y + 1][PlayerPosition.X - 3] is '█' or '#';

/* Kiểm tra các vị trí ở phía bên phải người chơi.
Nếu bất kỳ vị trí nào trong vùng [Y - 1, X + 3] đến [Y + 1, X + 3] có chứa '█' hoặc '#', hàm trả về true
Có tường ở bên phải */
bool WallRight() =>
	levels[level][PlayerPosition.Y - 1][PlayerPosition.X + 3] is '█' or '#' ||
	levels[level][PlayerPosition.Y][PlayerPosition.X + 3]     is '█' or '#' ||
	levels[level][PlayerPosition.Y + 1][PlayerPosition.X + 3] is '█' or '#';

// Hàm cập nhật giao diện
void Render()
{
	// Tạo ra hình ảnh của nhân vật người chơi dưới dạng mảng chuỗi, dựa trên trạng thái hiện tại.
	string[] playerSprite = RenderPlayerState();

	// Khởi tạo StringBuilder để tối ưu hiệu suất khi xây dựng chuỗi đầu ra.
	StringBuilder render = new();

	// Hoàn thành từng dòng
	render.AppendLine();

	Vòng lặp for duyệt qua từng hàng i trong levels[level]
	for (int i = 0; i < levels[level].Length; i++)
	{
		// Thêm 2 khoảng trắng ở mỗi dòng để tăng khoảng cách trong giao diện
		render.Append(' ');
		render.Append(' ');

		// Duyệt qua từng hàng trong hàng hiện tại của cấp độ
		for (int j = 0; j < levels[level][i].Length; j++)
		{
			// Lấy ký tự `c` đại diện cho phần tử ở vị trí `[i, j]` trong cấp độ hiện tại
			char c = levels[level][i][j];
			// Nếu ký tự là '@', thay thế bằng khoảng trắng để không hiển thị
			if (c is '@')
			{
				c = ' ';
			}
			// - `c` không phải là 'X' và không phải là '●' 
			if (c is not 'X' and not '●' &&
				// - Cột `j` phải nằm trong khoảng từ `PlayerPosition.X - 2` đến `PlayerPosition.X + 2`
				PlayerPosition.X - 2 <= j &&
				PlayerPosition.X + 2 >= j &&
				// - Hàng `i` phải nằm trong khoảng từ `PlayerPosition.Y - 1` đến `PlayerPosition.Y + 1`
				PlayerPosition.Y - 1 <= i &&
				PlayerPosition.Y + 1 >= i)
			{
				/* Nếu các điều kiện trên đúng, thay thế `c` bằng ký tự tương ứng từ `playerSprite`, 
				 để hiển thị hình ảnh của người chơi tại vị trí `[i, j]` */
				c = playerSprite[i - PlayerPosition.Y + 1][j - PlayerPosition.X + 2];
			}
			// Thêm ký tự `c`
			render.Append(c);
		}
		// Kết thúc mỗi dòng bằng xuống dòng
		render.AppendLine();
	}
	// Thêm một dòng trống vào
	render.AppendLine();
	// Thêm thông tin cấp độ và trọng lực hiện tại vào 'render', sử dụng hàm RenderGravityIdentifier() để xác định trọng lực
	render.AppendLine($"Level: {level}    Gravity: {RenderGravityIdentifier()}");
	// Đặt vị trí con trỏ ở góc trên bên trái màn hình (vị trí 0, 0)
	Console.SetCursorPosition(0, 0);
	// In chuỗi render ra
	Console.Write(render);
	// Ẩn con trỏ nhấp nháy
	Console.CursorVisible = false;
}

// Hàm trả về mảng chuỗi biểu diễn trạng thái của người chơi
string[] RenderPlayerState()
{
 	// Dựa vào playerState, hàm trả về trạng thái khối hình
	return (playerState) switch
	{
		// Trạng thái trượt theo hướng chéo lên phải hoặc xuống trái
		(PlayerState.Sliding | PlayerState.Up | PlayerState.Right) or
		(PlayerState.Sliding | PlayerState.Down | PlayerState.Left) =>
			[
				"╭──╮ ",
				"╰╮ ╰╮",
				" ╰──╯",
			],

		// Trạng thái trượt theo hướng chéo xuống phải hoặc lên trái
		(PlayerState.Sliding | PlayerState.Down | PlayerState.Right) or
		(PlayerState.Sliding | PlayerState.Up | PlayerState.Left) =>
			[
				" ╭──╮",
				"╭╯ ╭╯",
				"╰──╯ ",
			],

		// Trạng thái ép theo hướng lên phải
		(PlayerState.Squash | PlayerState.Up | PlayerState.Right) =>
			[
				"╭───╮",
				"╰─╮ │",
				"  ╰─╯",
			],

		// Trạng thái ép theo hướng xuống phải
		(PlayerState.Squash | PlayerState.Down | PlayerState.Right) =>
			[
				"  ╭─╮",
				"╭─╯ │",
				"╰───╯",
			],

		// Trạng thái ép theo hướng lên trái
		(PlayerState.Squash | PlayerState.Up | PlayerState.Left) =>
			[
				"╭───╮",
				"│ ╭─╯",
				"╰─╯  ",
			],

		// Trạng thái ép theo hướng xuống trái
		(PlayerState.Squash | PlayerState.Down | PlayerState.Left) =>
			[
				"╭─╮  ",
				"│ ╰─╮",
				"╰───╯",
			],

		// Trạng thái ép hoàn toàn theo hướng lên
		(PlayerState.Squash | PlayerState.Up) =>
			[
				"╭───╮",
				"╰───╯",
				"     ",
			],

		// Trạng thái ép hoàn toàn theo hướng xuống
		(PlayerState.Squash | PlayerState.Down) =>
			[
				"     ",
				"╭───╮",
				"╰───╯",
			],

		// Trạng thái ép hoàn toàn theo hướng phải
		(PlayerState.Squash | PlayerState.Right) =>
			[
				"  ╭─╮",
				"  │ │",
				"  ╰─╯",
			],

		// Trạng thái ép hoàn toàn theo hướng trái
		(PlayerState.Squash | PlayerState.Left) =>
			[
				"╭─╮  ",
				"│ │  ",
				"╰─╯  ",
			],
		_ =>
			// Trạng thái mặc định
			[
				"╭───╮",
				"│   │",
				"╰───╯",
			],
	};
}

// Hàm RenderGravityIdentifier trả về ký tự đại diện cho hướng trọng lực hiện tại
char RenderGravityIdentifier()
{
	return gravity switch
	{
		// Khi không có trọng lực, ký hiệu là '○'
		Direction.None  => '○',
		// Khi trọng lực hướng lên trên, ký hiệu là '^'
		Direction.Up    => '^',
		// Khi trọng lực hướng xuống dưới, ký hiệu là 'v'
		Direction.Down  => 'v',
		// Khi trọng lực hướng sang trái, ký hiệu là '<'
		Direction.Left  => '<',
		// Khi trọng lực hướng sang phải, ký hiệu là '>'
		Direction.Right => '>',

		// Xử lý lỗi nếu gặp giá trị không xác định cho 'gravity'
		_ => throw new NotImplementedException(),
	};
}

// Hàm PressToContinue chờ người dùng nhấn phím Enter để tiếp tục
void PressToContinue(ConsoleKey key = ConsoleKey.Enter)
{
	// Khởi tạo biến 'input' với giá trị mặc định
	ConsoleKey input = default;
	// Vòng lặp sẽ chạy cho đến khi người dùng nhấn đúng phím Enter
	while (input != key && !closeRequested)
	{
		// Đọc phím từ người dùng 
		input = Console.ReadKey(true).Key;
		if (input is ConsoleKey.Escape)
		{
			// Nếu người dùng nhấn phím Escape, đặt 'closeRequested' là true để dừng game
			closeRequested = true;
			// Thoát khỏi hàm ngay khi yêu cầu đóng
			return;
		}
	}
}

// Enum Direction định nghĩa các hướng di chuyển với giá trị kiểu bitwise
internal enum Direction
{
	// Không có hướng nào (giá trị mặc định 0)
	None  =      0,
	// Hướng lên trên, giá trị 1 (1 << 0, giá trị nhị phân 0001 là 1)
	Up    = 1 << 0,
	// Hướng xuống dưới, giá trị 2 (0010)
	Down  = 1 << 1,
	// Hướng sang trái, giá trị 4 (0100)
	Left  = 1 << 2,
	// Hướng sang phải, giá trị 8 (1000)
	Right = 1 << 3,
}

// Định nghĩa các trạng thái của trò chơi
internal enum GameState
{
	// Trạng thái mặc định của trò chơi
	Default =      0,
	// Trạng thái khi người chơi đã chết
	Died    = 1 << 0,
	// Trạng thái khi người chơi chiến thắng
	Won     = 1 << 1,
}

// Enum PlayerState định nghĩa các trạng thái của người chơi
internal enum PlayerState
{
	// Trạng thái trung lập
	Neutral   =      0,
	// Người chơi di chuyển lên
	Up        = 1 << 0, // ( 0001 - 1)
	// Người chơi di chuyển xuống
	Down      = 1 << 1, // (0010 - 2)
	// Người chơi di chuyển sang trái
	Left      = 1 << 2, // (0100 - 4)
	// Người chơi di chuyển sang phải
	Right     = 1 << 3, // (1000 - 8)
	// Người chơi đang trượt
	Sliding   = 1 << 4, // (10000 - 16)
	// Người chơi bị ép lại
	Squash    = 1 << 5, // (100000 -32)
}
