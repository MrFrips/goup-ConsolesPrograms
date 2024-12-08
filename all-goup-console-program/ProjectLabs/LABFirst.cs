using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Program1 : IGuacp
    {
        public void Run()
        {
            Console.WriteLine("Лабараторная 1.");
            Console.WriteLine("Des: Программа работает по формуле...\n");
            Console.WriteLine("");
            // Логика программы
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
            Console.WriteLine("");
            Console.WriteLine("Well Done!. Press any key to return to the menu");
            Console.ReadKey();
        }
    }
