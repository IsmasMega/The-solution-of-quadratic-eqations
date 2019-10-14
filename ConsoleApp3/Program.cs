using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            Console.WriteLine("                                        РЕШЕНИЕ КВАДРАТНЫХ УРАВНЕНИЙ");
            Console.WriteLine("Введите a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c:");
            int c = Convert.ToInt32(Console.ReadLine());
            int D = b * b - 4 * a * c;
            Console.WriteLine("Дискриминант равен " + D);
            if(D > 0)
            {
                 x = (-b + Math.Sqrt(D)) / (2 * a);
                 y = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Х1 = " + x);
                Console.WriteLine("Х2 = " + y);
            }
           else if(D == 0)
            {
                 x = -b / 2 * a;
                Console.WriteLine("Х = " + x);
            }
            else if(D < 0)
            {
                Console.WriteLine("Нет решений");
            }
            Console.ReadKey();
        }
    }
}
