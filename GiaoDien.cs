using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEH_Green
{
    internal class GiaoDien
    {
        public void DisplayIntro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string[] introArt = new string[]
            {
            @"╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗",
            @"║                                                                                                                      ║",
            @"║                                                    @@@@@    @@                               @@@@   @                ║",
            @"║                                                  @@@   @@@ @@                               @   @@@@                 ║",
            @"║                                                                                                                      ║",
            @"║                  @@@@@@@     @@@     @@@   @@@   @@@@@@@@@   @@@@    @@@          @@@@@@@@@    @@@                   ║",
            @"║                 @@@@@@@@@    @@@     @@@   @@@   @@@         @@@@@   @@@         @@@@@@@@@@@   @@@                   ║",
            @"║                @@@@      @   @@@     @@@   @@@   @@@         @@@@@@  @@@          @@@@    @@   @@@                   ║",
            @"║                @@@@          @@@@@@@@@@@   @@@   @@@@@@@@@   @@@ @@@ @@@             @@@       @@@                   ║",
            @"║                @@@@      @   @@@     @@@   @@@   @@@         @@@  @@@@@@         @@    @@@@    @@@                   ║",
            @"║                 @@@@@@@@@    @@@     @@@   @@@   @@@         @@@   @@@@@         @@@@@@@@@@@   @@@                   ║",
            @"║                  @@@@@@@     @@@     @@@   @@@   @@@@@@@@@   @@@    @@@@          @@@@@@@@@    @@@                   ║",
            @"║                                                                                                                      ║",
            @"║            @@@     @@@     @@@@@@@     @@@@    @@@   @@@     @@@                          ccc@@\                     ║",
            @"║            @@@     @@@    @@@@@@@@@    @@@@@   @@@   @@@     @@@                c@@@@@@\ /ccc@@@|                    ║",
            @"║             @@@   @@@    @@@     @@@   @@@@@@  @@@   @@@     @@@               /ccc@@@@@\@ccc@@/ccc\                 ║",
            @"║               @@@@@      @@@@@@@@@@@   @@@ @@@ @@@   @@@@@@@@@@@               cccccccc@@\@@@/cccc@@                 ║",
            @"║             @@@   @@@    @@@     @@@   @@@  @@@@@@   @@@     @@@                \ccccccc@|cccccc@@@/                 ║",
            @"║            @@@     @@@   @@@     @@@   @@@   @@@@@   @@@     @@@                   \ccccc@ccc@@@/                    ║",
            @"║            @@@     @@@   @@@     @@@   @@@    @@@@   @@@     @@@                   |           |                     ║",
            @"║                                                                                   /*  >     <  *\                    ║",
            @"║                                             ╔════════════════════════╗           |****   0   ****|                   ║",
            @"║                                             ║      >>> Enter <<<     ║           |***************|                   ║",
            @"║                                             ╚════════════════════════╝                                               ║",
            @"║                                                                                                                      ║",
            @"║                                                                                                                      ║",
            @"╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝"
            };

            foreach (string line in introArt)
            {
                Console.WriteLine(line);
            }
            Console.ResetColor();
        }
        public static void PrintEnterNFBanner(string[] banner)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;

            // Tính toán vị trí để in banner ra giữa màn hình
            int xPos = (consoleWidth - banner[0].Length) / 4;
            int yPos = (consoleHeight - banner.Length) / 4;

            // In banner ở vị trí đã tính toán
            for (int i = 0; i < banner.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth/7, yPos + i);
                Console.WriteLine(banner[i]);
                if (banner[i].Contains("╔" + "═" + "╚" + "║" + "╝")) // Đặt màu xanh lá cho phần có chữ 'c'
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                }

                else // Đặt màu trắng cho phần còn lại
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
            }
            Console.ResetColor();
        }
    }
}
