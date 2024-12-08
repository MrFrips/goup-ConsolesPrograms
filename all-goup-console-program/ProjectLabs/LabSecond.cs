using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Program2 : IGuacp
    {
        public void Run()
        {
            Console.WriteLine("Лабараторная 2.");
            Console.WriteLine("Des: Программа находит цыфру 5 в трёх значном числе.\nПри нахождении цыфры выводит 1, в противном случе 0");
            Console.WriteLine("");
            // Логика программы
            int check; //Переменная для вывода результата.
            int DigtNumb; //Переменная для водимиго числа.

            Console.Write("Enter a three-digit number: ");
            DigtNumb = Convert.ToInt16(Console.ReadLine());

            // Проверяем, является ли число трехзначным
            if (DigtNumb < 100 || DigtNumb > 999)
            {
                Console.WriteLine("Err: It's not a three-digit number...");
                Console.ReadKey();
                return;
            }

            // Проверяем, входит ли цифра 5 в число A
            if (DigtNumb / 100 == 5 || (DigtNumb / 10) % 10 == 5 || DigtNumb % 10 == 5)
            {
                check = 1;
            }
            else
            {
                check = 0;
            }

            Console.WriteLine($"Res P: {check}");

            Console.WriteLine("Well Done!. Press any key to return to the menu.");
            Console.ReadKey();
        }
    }

