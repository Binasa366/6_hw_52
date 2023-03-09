//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-100, 101);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],4} \t");
        Console.WriteLine();
    }
}

void arif(int[,] array, int i, int j)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int rows;
    int cols;
    for (cols = 0; cols < array.GetLength(1); cols++)
    {
        double sum = 0;
        for (rows = 0; rows < array.GetLength(0); rows++)
        {
            sum = sum + array[rows, cols];
        }
        Console.Write($"{sum / (rows):F1}; ");
    }
}


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
arif(array, rows, cols);

