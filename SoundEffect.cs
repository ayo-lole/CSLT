using System;
using System.Threading.Tasks;
using System.IO;
using System.Media;

public class MusicPlayer
{
    private string filePath;

    // Constructor để khởi tạo đường dẫn tới file WAV
    public MusicPlayer(string filePath)
    {
        this.filePath = filePath;
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
                    using (SoundPlayer player = new SoundPlayer(filePath))
                    {
                        player.PlaySync();  // Phát nhạc đồng bộ trong task mới
                        
                    }
                }
                else
                {
                    Console.WriteLine("File không tồn tại hoặc đường dẫn không đúng.");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Lỗi định dạng file: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi phát nhạc: {ex.Message}");
            }
        });
    }
}
