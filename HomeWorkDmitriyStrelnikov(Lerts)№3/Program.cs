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
            Random rnd = new Random();
           
            int x1 = rnd.Next(1, 100);
            int y1 = rnd.Next(1, 25);
            Console.SetCursorPosition(x1, y1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("*");
            Console.ResetColor(); 

            int x2 = rnd.Next(1, 100);
            int y2 = rnd.Next(1, 25);
            Console.SetCursorPosition(x2, y2);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("*");
            Console.ResetColor();

            Console.SetCursorPosition(0, 26);
            dictance(x1, y1, x2, y2);
            
            Console.ReadLine();
        }

        static void dictance(int x1, int y1, int x2, int y2)
        {
            double r;
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Растояние между двумя точками: = {0:f2}", r);
        }
    }
}
