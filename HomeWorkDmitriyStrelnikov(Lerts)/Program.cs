using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDmitriyStrelnikov_Lerts_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            byte years = byte.Parse(Console.ReadLine());
            Console.Write("Введите ваш рост: ");
            float height = float.Parse(Console.ReadLine());
            Console.Write("Введите ваш вес: ");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("\n\tВывод спомощью склеивания.");
            Console.WriteLine("Ваше имя: " + name + "\nВаша фамилия: " + surname + "\nВаш возраст: " + years + "\nВаш рост: " + height + "\nВаш вес: " + weight);


            Console.ReadLine();
        }
    }
}
