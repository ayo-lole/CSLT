using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEH_Green
{
    internal class UehQuestionHandle
    {
        public static void PositionAtBottom()
        {
            int windowHeight = Console.WindowHeight;
            int bottomPosition = windowHeight = 18;

            Console.SetCursorPosition(0, bottomPosition);
        }
        public static void ClearQuestionAndAnswer(int startLine, int lineCount)
        {
            for (int i = 0; i < lineCount; i++)
            {
                Console.SetCursorPosition(0, startLine + i);
                Console.Write(new string(' ', Console.WindowWidth));
            }
            Console.SetCursorPosition(0, startLine);
        }
    }
}
