//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//1 5 8 5
//4 9 4 2
//7 2 2 6
// 3 4 7
//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49


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

int[,] MultiplicationMatrix(int[,] array1, int[,] array2, int line, int stolb)
{
    int[,] multiMatrix = new int[line, stolb];
    for (int i = 0; i < multiMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiMatrix.GetLength(1); j++)
        {
            multiMatrix[i, j] = array1[i, j] * array2[i, j];
        }

    }
    return multiMatrix;
}
Console.Clear();
Console.Clear();
int m = UserInputInt("Введите   длину строки масива ");
int n = UserInputInt("Введите  длину  столбцов масива ");

int[,] firstmatrix = GetMatrix(m, n);
int[,] secondmatrix = GetMatrix(m, n);
PrintMatrix(firstmatrix);
Console.WriteLine();
PrintMatrix(secondmatrix);

Console.WriteLine();
int[,] resultmatrix = MultiplicationMatrix(firstmatrix, secondmatrix, m, n);
PrintMatrix(resultmatrix);
