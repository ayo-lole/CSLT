using System; 
using System.Threading.Tasks; 
using System.IO; 
using System.Media; 

public class MusicPlayer // Định nghĩa lớp MusicPlayer
{
    private string filePath; // Biến để lưu đường dẫn tới file âm thanh

    // Constructor để khởi tạo đường dẫn tới file WAV
    public MusicPlayer(string filePath)
    {
        this.filePath = filePath; // Gán đường dẫn file từ tham số
    }

    // Phương thức để phát nhạc không đồng bộ trong một luồng mới
    public void PlayMusicInNewThread()
    {
        Task.Run(() => // Tạo một task để chạy phát nhạc trong luồng khác
        {
            try
            {
                // Kiểm tra xem file có tồn tại không
                if (File.Exists(filePath))
                {
                    // Sử dụng SoundPlayer để phát nhạc
                    using (SoundPlayer player = new SoundPlayer(filePath))
                    {
                        player.PlaySync();  // Phát nhạc đồng bộ trong task mới
                    }
                }
                else
                {
                    // Thông báo nếu file không tồn tại
                    Console.WriteLine("File không tồn tại hoặc đường dẫn không đúng.");
                }
            }
            catch (InvalidOperationException ex) // Bắt lỗi nếu định dạng file không đúng
            {
                Console.WriteLine($"Lỗi định dạng file: {ex.Message}");
            }
            catch (Exception ex) // Bắt lỗi chung
            {
                Console.WriteLine($"Lỗi phát nhạc: {ex.Message}");
            }
        });
    }
}
