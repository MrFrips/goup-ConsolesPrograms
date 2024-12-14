public class Program5 : IGuacp
{
    public void Run()
    {
        Console.WriteLine("Лабараторная 5.");
        Console.WriteLine("Des: Программа вычисляет системы варианта No8...\n");
        Console.WriteLine("");
        // Логика программы
        // Задача 1: Перевести в десятичную систему из шестнадцатеричной
        string hexNumber1 = "3A4B";
        string hexNumber2 = "C5";
        int decimalNumber1 = Convert.ToInt32(hexNumber1, 16);
        int decimalNumber2 = Convert.ToInt32(hexNumber2, 16);

        Console.WriteLine($"Шестнадцатеричное число {hexNumber1} в десятичной системе: {decimalNumber1}");
        Console.WriteLine($"Шестнадцатеричное число {hexNumber2} в десятичной системе: {decimalNumber2}");

        // Задача 2: Перевести в восьмеричную систему из шестнадцатеричной
        string octalNumber1 = Convert.ToString(decimalNumber1, 8);
        string octalNumber2 = Convert.ToString(decimalNumber2, 8);

        Console.WriteLine($"Шестнадцатеричное число {hexNumber1} в восьмеричной системе: {octalNumber1}");
        Console.WriteLine($"Шестнадцатеричное число {hexNumber2} в восьмеричной системе: {octalNumber2}");

        // Задача 3: Перевести в двоичную систему с точностью до двух знаков после запятой
        double decimalValue = 2.81;
        string binaryValue = Convert.ToString((int)decimalValue, 2); // Целая часть
        double fractionalPart = decimalValue - (int)decimalValue; // Дробная часть

        // Преобразование дробной части в двоичную
        binaryValue += ".";
        for (int i = 0; i < 2; i++)
        {
            fractionalPart *= 2;
            if (fractionalPart >= 1)
            {
                binaryValue += "1";
                fractionalPart -= 1;
            }
            else
            {
                binaryValue += "0";
            }
        }

        Console.WriteLine($"Десятичное число {decimalValue} в двоичной системе (с точностью до двух знаков): {binaryValue}");

        // Задача 4: Произвести вычитание в разрядной сетке ЭВМ
        int num1 = 145;
        int num2 = 45;
        int result = num1 - num2;

        Console.WriteLine($"Результат вычитания {num1} - {num2}: {result}");
        Console.WriteLine("Well Done!. Press any key to return to the menu.");
        Console.ReadKey();
    }
}
