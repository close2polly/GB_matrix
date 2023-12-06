Console.WriteLine("Напишите x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите y");
int y = Convert.ToInt32(Console.ReadLine());

// Тестовый массив
int[,] array = new int[3, 4] {
    {32,24,64,19},
    {31,54,76,100},
    {79,81,65,5},
};

if (x > array.GetLength(0) - 1)
{
    Console.WriteLine("Такого элемента не существует");
    Environment.Exit(1);
}

if (y > array.GetLength(1) - 1)
{
    Console.WriteLine("Такого элемента не существует");
    Environment.Exit(1);
}

Console.WriteLine($"Ваше число: {array[x, y]}");