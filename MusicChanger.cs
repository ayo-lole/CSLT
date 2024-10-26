using System.Collections.Generic;

public class MusicManager
{
    private static MusicPlayer currentMusic = null;

    public static void PlayMusic(string filePath)
    {
        // Nếu có nhạc đang phát, dừng nhạc hiện tại
        if (currentMusic != null)
        {
            currentMusic.Stop();
        }

        // Tạo nhạc mới và phát
        currentMusic = new MusicPlayer(filePath);
        currentMusic.Play();
    }

    public static void StopCurrentMusic()
    {
        if (currentMusic != null)
        {
            currentMusic.Stop();
            currentMusic = null;
        }
    }
}
