using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_goup_console_program
{
    internal class LABFirst
    {
        static void Main(string[] args)
        {
            int A, P;

            Console.Write("Введите трехзначное число A: ");
            A = int.Parse(s: Console.ReadLine());

            // Проверяем, является ли число трехзначным
            if (A < 100 || A > 999)
            {
                Console.WriteLine("Err: not a 3.");
                return;
            }

            // Проверяем, входит ли цифра 5 в число A
            if (A / 100 == 5 || (A / 10) % 10 == 5 || A % 10 == 5)
            {
                P = 1;
            }
            else
            {
                P = 0;
            }

            Console.WriteLine($"Res P: {P}");
            /*
            Console.WriteLine("Default > 5");
            Console.Write("Write pls x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Default > 5");
            Console.Write("Write pls y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            // Вычисление значения функции Z
            double z = (Math.Pow(Math.Sin(x), 5) * Math.Pow(Math.Cos(y), 5)) / 25 +
            (Math.Pow(Math.Sin(x), 3) - Math.Pow(Math.Cos(y), 3)) / 125;

            Console.WriteLine("result Z: " + z);
            Console.ReadLine();
            AMain();
            */
        }
    }
}
