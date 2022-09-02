// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void FillArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = new Random().Next(-10, 10);
        }
    }
}

void PrintArray(int[,] matr)
{

    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m, n]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число строк:");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов:");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[str, col];
FillArray(array);
PrintArray(array);

if (str < array.GetLength(0) && col < array.GetLength(1)) 
{
    Console.WriteLine(array[str, col]);
}    
else Console.WriteLine($"{str}{col} -> такого числа в массиве нет");



