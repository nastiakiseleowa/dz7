// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
int sum = 0;
double result = 0;
int[,] matrix = new int[str, col];
FillArray(matrix);
PrintArray(matrix);

for (int i = 0; i < matrix.GetLength(1); i++)
{
    sum = 0;
    result = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sum += matrix[j,i];
    }
    result = (double)sum / (matrix.GetLength(0));
    Console.Write($"{result} ");
}
