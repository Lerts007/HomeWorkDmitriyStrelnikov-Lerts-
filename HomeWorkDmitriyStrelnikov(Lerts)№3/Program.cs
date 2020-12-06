using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDmitriyStrelnikov_Lerts__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndX = new Random();
            Random rndY = new Random();

            int x1 = rndX.Next(1, 100);
            int y1 = rndY.Next(1, 25);
            Console.SetCursorPosition(x1, y1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("*");
            Console.ResetColor();

            int x2 = rndX.Next(1, 100);
            int y2 = rndY.Next(1, 25);
            Console.SetCursorPosition(x2, y2);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("*");
            Console.ResetColor();

            Console.SetCursorPosition(0, 26);
            double r;
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Растояние между двумя точками: = {0:f2}", r);


            Console.ReadLine();
        }
    }
}
