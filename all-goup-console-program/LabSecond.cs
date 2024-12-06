using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_goup_console_program
{
    public class Program2 : IGuacp
    {
        public void Run()
        {
            Console.WriteLine("Лабараторная 2.");
            Console.WriteLine("Des: ");
            Console.WriteLine("");
            // Логика программы 1
            int P; //A

            Console.Write("Enter a three-digit number: ");
            int A = Convert.ToInt16(Console.ReadLine());

            // Проверяем, является ли число трехзначным
            if (A < 100 || A > 999)
            {
                Console.WriteLine("Err: It's not a three-digit number...");
                Console.ReadKey();
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

            Console.WriteLine("Well Done!. Press any key to return to the menu.");
            Console.ReadKey();
        }
    }
}
