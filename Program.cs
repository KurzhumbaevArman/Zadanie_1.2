using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontur_z_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            float y;

            Console.Write("Введите координату x  ");
            x = float.Parse(Console.ReadLine());

            Console.Write("Введите координату y  ");
            y = float.Parse(Console.ReadLine());

            if (Math.Abs(x) <= 1 && Math.Abs(y) <= 1)
            {
                if (Math.Abs(x) + y <= 1)
                    Console.Write("Данная точка находится внутри контура");
                else Console.Write("Данная точка лежит за границами контура");
            }
            else
                Console.Write("Данная точка лежит за границами контура");
            Console.ReadKey();
        }
    }
}
