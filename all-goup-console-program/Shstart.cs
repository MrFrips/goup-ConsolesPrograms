using all_goup_console_program;

interface IGuacp
{
    void Run();
}


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            ShowMenu();

            Console.Write("Choose your Pokémon: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                if (choice == 0)
                {
                    //GoAway();
                    Console.WriteLine("Exiting.");
                    break;
                }

                IGuacp selectedProgram = GetProgram(choice);
                if (selectedProgram != null)
                {
                    Console.Clear();
                    selectedProgram.Run();
                }
                else
                {
                    Console.WriteLine("Err 404. Try again pls.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Введите корректный номер.");
                Console.ReadKey();
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("Main Menu:");
        Console.WriteLine("1. Лабараторная 1");
        Console.WriteLine("2. Лабараторная 2");
        Console.WriteLine("3. Лабараторная 5");
        Console.WriteLine("4. Заглушка");
        Console.WriteLine("0. Exit");
    }

    static IGuacp GetProgram(int choice)
    {
        //Нужна проверка если число больше заданного перемещать его в GoAway();
        IGuacp redo = choice switch
        {
            1 => new Program1(),
            2 => new Program2(),
            3 => new Program5(),
            4 => new Plug(),
            _ => null

        };
        return redo;
    }
}