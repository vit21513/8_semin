//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

int[,] GetMatrix(int m)
{
    int[,] matrix = new int[m, m];
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

void FindMatrixMinLine(int[,] array)
{
    int res = 0;
    int index = 0;
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i, j];
        }
        if (i == 0) res = summ;
        if (res > summ)
        {
            res = summ;
            index = i;
        }
        summ = 0;
    }
    Console.Write($" Наименьшая сумма элементов строки  является строка с номером {index + 1} ");
}
Console.Clear();
int m = UserInputInt("Введите   размер массива  ");

int[,] matrixResult = GetMatrix(m);
PrintMatrix(matrixResult);
Console.WriteLine();
FindMatrixMinLine(matrixResult);
