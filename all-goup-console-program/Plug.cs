using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_goup_console_program
{
    public class Plug : IGuacp
    {
        public void Run()
        {
            Console.WriteLine("PLUG.");
            Console.WriteLine("");
            // Логика программы 1
            Console.WriteLine("Oups, i think you've hit the console XD.");
            Console.ReadKey();
        }
    }
}
