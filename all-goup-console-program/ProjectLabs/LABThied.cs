public class Program3 : IGuacp
{
    public void Run()
    {
        Console.WriteLine("Лабараторная 3.");
        Console.WriteLine("Des: Осмысловая сортировка\n");
        Console.WriteLine("");
        // Логика программы
        Console.Write("Введите количество элементов массива array-element: ");
        int arraySize = int.TryParse(Console.ReadLine(), out int _size) ? _size : 0;
        if (arraySize < 0)
        {

        }

        // Генерируем массив с уникальными случайными числами
        int[] array = GenerateRandomArray(arraySize);

        // Выводим исходный массив
        Console.WriteLine("Исходный массив start array:");
        PrintArray(array);

        // Сортировка выбором
        SelectionSort(array);

        // Выводим отсортированный массив
        Console.WriteLine("Отсортированный массив sort array:");
        PrintArray(array);

        static int[] GenerateRandomArray(int size)
        {
            int[] array = new int[size];
            var random = new Random(Guid.NewGuid().GetHashCode());
            bool[] used = new bool[size];

            for (int i = 0; i < size; i++)
            {
                int num;
                do
                {
                    num = random.Next(1, size + 1);
                } while (used[num - 1]);

                array[i] = num;
                used[num - 1] = true;
            }
            return array;
        }

        static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Меняем местами минимальный элемент с текущим
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Well Done!. Press any key to return to the menu.");
        Console.ReadKey();
    }
}