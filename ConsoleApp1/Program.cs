using System;
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
            string a1, b1, c1, D1;
            Double a, b, c, D;
            a1 = args[0];
            b1 = args[1];
            c1 = args[2];
            D1 = args[3];
            a = Convert.ToDouble(args[0]);
            b = Convert.ToDouble(args[1]);
            c = Convert.ToDouble(args[2]);
            D = Convert.ToDouble(args[3]);

            /* try {
                 a = Convert.ToDouble(args[0]);}
             catch (ArgumentException)
             {Console.WriteLine("Ошибка аргумента"); }
             try
             {
                 b = Convert.ToDouble(args[1]);
             }
             catch (ArgumentException)
             { Console.WriteLine("Ошибка аргумента"); }
             try
             {
                 c = Convert.ToDouble(args[2]); 
             }
             catch (ArgumentException)
             { Console.WriteLine("Ошибка аргумента"); }
             try
             {
                 D = Convert.ToDouble(args[3]); ;
             }
             catch (ArgumentException)
             { Console.WriteLine("Ошибка аргумента"); }
             */


            /*          Console.WriteLine("Введите коэффиценты квадратного уравнения a,b,c");

                      Console.WriteLine("Введите a: ");
                      a = Convert.ToDouble(Console.ReadLine());

                      Console.WriteLine("Введите b: ");
                      b = Convert.ToDouble(Console.ReadLine());

                      Console.WriteLine("Введите c: ");
                      c = Convert.ToDouble(Console.ReadLine());
                      */
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