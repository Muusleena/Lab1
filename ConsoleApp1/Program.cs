﻿using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {

            Double a, b, c, D;

            Console.WriteLine("Введите коэффиценты квадратного уравнения a,b,c");

            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());

            D = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0 && b == 0)
            {

                Console.WriteLine("Корней нет");
                Console.ReadKey();

            }
            else if (a == 0)
            {

                Console.WriteLine("x = ", -c / b);
                Console.ReadKey();
            }

            else if (b == 0)
            {

                Console.WriteLine("x1 = {0} \n x2 = {1}", Math.Sqrt(-1 * c / a), -1 * Math.Sqrt(-1 * c / a));
                Console.ReadKey();
            }





            else if (D >= 0)
            {

                Console.WriteLine("x1 = {0} \n x2 = {1}", (-b + Math.Sqrt(D)) / (2 * a), (-b - Math.Sqrt(D)) / (2 * a));
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Корней нет");
                Console.ReadKey();
            }
        }
    }
}