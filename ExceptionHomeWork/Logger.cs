using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomeWork
{
    internal class Logger
    {
        

        public static void LogError (string message, string code)
        {
            string dateTime = DateTime.Now.ToString("HH:mm:ss");

            Console.Write($"[ {dateTime}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" ERR ");
            Console.ResetColor();
            Console.Write($"] {code} : {message}");
            Console.WriteLine();

        }

    }
}
