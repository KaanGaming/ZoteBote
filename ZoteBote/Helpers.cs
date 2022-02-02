using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoteBote
{
    static class Helpers
    {
        public static void WriteLine(this ConsoleColor c, string text)
        {
            Console.ForegroundColor = c;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void Write(this ConsoleColor c, string text)
        {
            Console.ForegroundColor = c;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
