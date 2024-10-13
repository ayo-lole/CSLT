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
                Console.SetCursorPosition(Console.WindowWidth / 7, yPos + i);
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

        public static void printUEHBuilding()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string[] truong1 = new string[]
                {
                     "     ____________________________________________________________________    " + '\n' +
                    "     |          ║║ | | | | | | | | | | | | | |║║   ||  ||||  ||||  ||||   |    " + '\n' +
                    "     |__________║║ | | | | | | | | | | | | | |║║   ||  ||||  ||||  ||||   |    " + '\n' +
                    "     |   UEH    ║║_|_|_|_|_|_|_|_|_|_|_|_|_|_|║║═══||══||||══||||══||||═══|    " + '\n' +
                    "     |university║║ | | | | | | | | | | | | | |║║   ||  ||||  ||||  ||||   |    " + '\n' +
                    "     |__________║║ | | | | | | | | | | | | | |║║═══||══||||══||||══||||═══|    " + '\n' +
                    "     |          ║╚════════════════════════════╝║   ||  ||||  ||||  ||||   |    " + '\n' +
                    "     |          ║  ║  ║  ║  ║  ║  ║  ║  ║  ║   ║___||__||||__||||__||||___|    " + '\n' +
                    "     |          ║  ║  ║  ║  ║  ║  ║__║__║__║___║   ║   ║   ║   ║   ║   ║  |    " + '\n' +
                    "     |          ║  ║  ║  ║  ║  ║  ║  ║  ║  ║   ║   ║   ║   ║   ║   ║   ║  |    " + '\n' +
                    "     |__________║__║__║__║__║__║__║  ║  ║  ║   ║___║___║___║___║___║___║__|    "
                };
        }




        public static void printUEHBuilding2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string[] truong3 = new string[]
                {
            "      _________________    " + '\n' +
            "     |___║___║___║__|__|   " + '\n' +
            "     |___║___║___║__|__|   " + '\n' +
            "     |═══║═══║═══║__|__|   " + '\n' +
            "     |═══║═══║═══║__|__|   " + '\n' +
            "     |═══║═══║═══║__|__|   " + '\n' +
            "     |═══║═══║═══║__|__|   " + '\n' +
            "     |═══║═══║═══║__|__|   " + '\n' +
            "     |═══║═══║═══║__|__|   " + '\n' +
            "     |═══║═══║═══║__|__|   " + '\n' +
            "     |═══║═══║═══║══|══|   " + '\n' +
            "     |_ĐẠI HỌC KINH TẾ_|   " + '\n' +
            "     |===║===║===║__║__|   " + '\n' +
            "     |   ║   ║   ║__║__|   " + '\n' +
            "     |___║___║___║__║__|   " + '\n' +
            "     |   ║   ║   ║  ║  |   " + '\n' +
            "     |___║___║___║__║__|   ",

            };
        }


        public static void printUEHBuilding3()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string[] truong1 = new string[]
                {
              "          __________     " + '\n' +
             "          |  UEH     |     " + '\n' +
             "     _____|____════════╗   " + '\n' +
             "     ||   W   |║       ║   " + '\n' +
             "     ||western|║       ║   " + '\n' +
             "     || sydney|║       ║   " + '\n' +
             "     |█████████║███████║   " + '\n' +
             "     | █ █ █ █ ║       ║   " + '\n' +
             "     | █ █ █ █ ║       ║   " + '\n' +
             "     |█████████║███████║   " + '\n' +
             "     | |     | ║       ║   " + '\n' +
             "     | | ISB | ║       ║   " + '\n' +
             "     |▄|▄▄▄▄▄|▄▄▄▄▄▄▄▄▄|   " + '\n' +
             "     |--------|    |   |   " + '\n' +
             "     |--------|    |   |   " + '\n' +
             "     |________|____|___|   ",

                    };
        }

        public static void printUEHBuilding4()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string[] truong1 = new string[]
                {
                  "     ____________________" + '\n' +
                 "     |        ║     ║_____|" + '\n' +
                 "     |   _____║     ║||||||" + '\n' +
                 "     |___|||||║     ║═════|" + '\n' +
                 "     |        ║     ║_____|" + '\n' +
                 "     |   _____║ UEH ║||||||" + '\n' +
                 "     |___|||||║.....║═════|" + '\n' +
                 "     |        ║.....║_____|" + '\n' +
                 "     |   _____║     ║||||||" + '\n' +
                 "     |___|||||║     ║═════|" + '\n' +
                 "     |   _____║     ║_____|" + '\n' +
                 "     |   |||||║     ║||||||" + '\n' +
                 "     |========╚═════╝═════|" + '\n' +
                 "     |     ║  |           |" + '\n' +
                 "     |     ║  |           |" + '\n' +
                 "     |_____║__|___________|   ",

                        };
        }

        public static void printUEHBuilding5()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string[] truong1 = new string[]
                {
                     "                    ________                   " + '\n' +
                     "      ______________║ ║   ║ ║______________    " + '\n' +
                     "     |              ║ ║   ║ ║              |   " + '\n' +
                     "     |              ║ ║   ║ ║              |   " + '\n' +
                     "     |           ___║ ║ U ║ ║___           |   " + '\n' +
                     "     |          ║   ║ ║ E ║ ║   ║          |   " + '\n' +
                     "     |       ___║   ║ ║ H ║ ║   ║___       |   " + '\n' +
                     "     |      ║   ║   ║ ║   ║ ║   ║   ║      |   " + '\n' +
                     "     |      ║   ║   ║ ║   ║ ║   ║   ║      |   " + '\n' +
                     "     |      ║   ║   ║ ║   ║ ║   ║   ║      |   " + '\n' +
                     "     |   ___║   ║   ║ ╚═══╝ ║   ║   ║___   |   " + '\n' +
                     "     |  ║   ║   ║   ║  _ _  ║   ║   ║   ║  |   " + '\n' +
                     "     |  ║   ║   ║   ║ | | | ║   ║   ║   ║  |   " + '\n' +
                     "     |__║___║___║___║_|_|_|_║___║___║___║__|   ",

                            };
        }


    }
}
