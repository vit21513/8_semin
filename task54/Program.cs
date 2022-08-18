//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
///Например, задан массив:
//1 4 7 2
///5 9 2 3
// 4 2 4/
// итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

int UserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;

}

void SortMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = 0;
                    temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}

Console.Clear();
int m = UserInputInt("Введите   длину строки масива ");
int n = UserInputInt("Введите  длину  столбцов масива ");
int[,] matrixResult = GetMatrix(m, n);
PrintMatrix(matrixResult);
Console.WriteLine();
SortMatrix(matrixResult);
PrintMatrix(matrixResult);
