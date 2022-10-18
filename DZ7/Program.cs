//Zadacha47();
void Zadacha47()
{
    Console.WriteLine("Задайте количество строк двумерного массива:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте количество столбцов двумерного массива:");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] twoDimArray = new double[m, n];
    Random rnd = new Random();
    void PrintArray(double[,] matr)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            { Console.Write($"{matr[i, j]} "); }
            Console.WriteLine();
        }
    }

    void FillArray(double[,] matr)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            { matr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0); }
        }
    }
    FillArray(twoDimArray);
    Console.WriteLine();
    PrintArray(twoDimArray);
}
//Zadacha50();
void Zadacha50()
{
    Console.WriteLine("Введите размеры массива");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToInt32(new Random().Next(0, 21));
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t  ");
        Console.WriteLine();
    }

    Console.WriteLine("введите позицию элемента в двумерном массиве");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > m && b > n)
        Console.WriteLine("такого числа нет");
    else
    {
        object c = array.GetValue(a, b);
        Console.WriteLine(c);
    }
}

Zadacha52();
void Zadacha52()
{
    int[,] array = new int[4, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToInt32(new Random().Next(-100, 100));
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t  ");
        Console.WriteLine();
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int srAr = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            srAr += array[j, i];

        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr / 4}");
    }
}