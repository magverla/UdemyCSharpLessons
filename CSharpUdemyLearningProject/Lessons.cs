using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUdemyLearningProject
{
    
    internal class Lessons
    {
        public static void LessonOne()
        {
            Console.WriteLine("Hello World!");
            ConsoleColor backGroundColor = ConsoleColor.Green;
            ConsoleColor foreGroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = backGroundColor;
            Console.ForegroundColor = foreGroundColor;
            Console.WriteLine($"Forgroundcolor ist {foreGroundColor} und Backgroundcolor ist {backGroundColor}");
            Console.ResetColor();

        }

        public static void LessonTwo()
        {
            int v1 = 25;
            Int64 v2 = v1;
            Console.WriteLine($"Byte value von v2 ist {(byte)v2}");
            Console.WriteLine($"Byte value von v1 ist {(byte)v1}");
            double d1 = (double)v2;
            double d2 = (double)v1;
            Console.WriteLine($"Byte value von d1 ist {(byte)d1}");
            Console.WriteLine($"Byte  value von d2 ist {(byte)d2}");
            Console.WriteLine("Das ist ein {0}", "Test");
            Console.WriteLine("{0} hat die Länge {1}", "Test", "Test".Length);
        }

    }
}
