using System; 
using System.Threading; 

// Mảng chứa các khung hình cho animation khi người chơi đang chạy
string[] runningAnimation =
[
	#region Frames
	// 0
	@"       " + '\n' +
	@"       " + '\n' +
	@"  __O  " + '\n' +
	@" / /\_," + '\n' +
	@"__/\   " + '\n' +
	@"    \  ",
	// 1
	@"       " + '\n' +
	@"       " + '\n' +
	@"   _O  " + '\n' +
	@"  |/|_ " + '\n' +
	@"  /\   " + '\n' +
	@" /  |  ",
	// 2
	@"       " + '\n' +
	@"       " + '\n' +
	@"    O  " + '\n' +
	@"  </L  " + '\n' +
	@"   \   " + '\n' +
	@"   /|  ",
	// 3
	@"       " + '\n' +
	@"       " + '\n' +
	@"   O   " + '\n' +
	@"   |_  " + '\n' +
	@"   |>  " + '\n' +
	@"  /|   ",
	// 4
	@"       " + '\n' +
	@"       " + '\n' +
	@"   O   " + '\n' +
	@"  <|L  " + '\n' +
	@"   |_  " + '\n' +
	@"   |/  ",
	// 5
	@"       " + '\n' +
	@"       " + '\n' +
	@"   O   " + '\n' +
	@"  L|L  " + '\n' +
	@"   |_  " + '\n' +
	@"  /  | ",
	// 6
	@"       " + '\n' +
	@"       " + '\n' +
	@"  _O   " + '\n' +
	@" | |L  " + '\n' +
	@"   /-- " + '\n' +
	@"  /   |",
	#endregion
];

// Mảng chứa các khung hình cho animation khi người chơi đang nhảy
string[] jumpingAnimation =
[
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
	@"  __O__" + '\n' +
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
];

// Khung hình cho chướng ngại vật
string hurdleFrame =
	#region Frame
	@"  ___  " + '\n' +
	@" |   | " + '\n' +
	@" | . | ";
	#endregion

int position = 0; // Biến vị trí để theo dõi điểm số
int? runningFrame = 0; // Khung hình đang chạy animation
int? jumpingFrame = null; // Khung hình đang nhảy animation

Console.CursorVisible = false; // Ẩn con trỏ
if (OperatingSystem.IsWindows()) // Thiết lập kích thước cửa sổ nếu chạy trên Windows
{
	Console.WindowWidth = 120;
	Console.WindowHeight = 20;
}
Console.Clear(); // Xóa màn hình console

// Vòng lặp chính của trò chơi
while (position < int.MaxValue) // Chạy đến khi điểm số đạt tới giá trị tối đa
{
	if (Console.KeyAvailable) // Kiểm tra xem có phím nào được nhấn không
	{
		switch (Console.ReadKey(true).Key) // Đọc phím đã nhấn
		{
			case ConsoleKey.Escape: // Nếu phím Esc được nhấn
				Console.Clear();
				Console.Write("Hurdles was closed."); // Thông báo đóng trò chơi
				return; // Thoát khỏi vòng lặp
			case ConsoleKey.UpArrow: // Nếu phím mũi tên lên được nhấn
				if (!jumpingFrame.HasValue) // Kiểm tra xem người chơi có đang nhảy không
				{
					jumpingFrame = 0; // Bắt đầu animation nhảy
					runningFrame = null; // Ngừng animation chạy
				}
				break;
		}
	}

	// Kiểm tra điều kiện kết thúc trò chơi
	if (position >= 100 && position % 50 is 0 && 
		(!jumpingFrame.HasValue || !(2 <= jumpingFrame && jumpingFrame <= 7)))
	{
		Console.Clear(); // Xóa màn hình
		Console.Write("Game Over. Score " + position + "."); // Thông báo game over
		return; // Thoát khỏi vòng lặp
	}

	// Lựa chọn khung hình cho animation
	string playerFrame =
		jumpingFrame.HasValue ? jumpingAnimation[jumpingFrame.Value] :
		runningAnimation[runningFrame!.Value];

	// Vẽ khung hình của người chơi
	Console.SetCursorPosition(4, 10); // Đặt vị trí vẽ
	Render(playerFrame, true); // Vẽ khung hình người chơi
	RenderHurdles(true); // Vẽ chướng ngại vật

	// Hiển thị thêm thông tin nếu cần
	if (position % 50 is 5)
	{
		Console.SetCursorPosition(0, 13);
		Render(
			@"       " + '\n' +
			@"       " + '\n' +
			@"       ", true);
	}

	// Xử lý hiển thị khung hình
	if (position % 50 < 3)
	{
		Console.SetCursorPosition(4, 10);
		Render(playerFrame, false);
		RenderHurdles(false);
	}
	else
	{
		RenderHurdles(false);
		Console.SetCursorPosition(4, 10);
		Render(playerFrame, false);
	}

	// Cập nhật khung hình cho animation
	runningFrame = runningFrame.HasValue
		? (runningFrame + 1) % runningAnimation.Length // Chuyển đến khung hình tiếp theo
		: runningFrame;
	jumpingFrame = jumpingFrame.HasValue
		? jumpingFrame + 1 // Cập nhật khung hình nhảy
		: jumpingFrame;

	if (jumpingFrame >= jumpingAnimation.Length) // Nếu đã qua hết các khung hình nhảy
	{
		jumpingFrame = null; // Đặt lại trạng thái nhảy
		runningFrame = 2; // Quay lại khung hình chạy thứ 2
	}
	position++; // Tăng điểm số
	Thread.Sleep(TimeSpan.FromMilliseconds(80)); // Tạm dừng 80ms
}

Console.Clear(); // Xóa màn hình
Console.Write("You Win."); // Thông báo chiến thắng
