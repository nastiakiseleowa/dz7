/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
void PrintArray(int[,] matr)
{

    for (int m = 0; m < 3; m++)
    {
        for (int n = 0; n < 4; n++)
        {
            Console.Write($"{matr[m, n]}");
        }
        Console.WriteLine();
    }
}
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
int[,] matrix = new int[3, 4];

FillArray(matrix);
PrintArray(matrix);
*/

Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-10, 10);
        Console.Write($"{matrix[i, j]} ");
    }

    Console.WriteLine();
}