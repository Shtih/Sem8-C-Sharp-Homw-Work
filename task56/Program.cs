// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] RandomArray(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }    
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int MinSummElementsRow (int [,] matrix)
{
    int Sum;
    int temp = 0;
    int stringMinSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum += matrix[i,j];
        }
        if (i == 0)
        {
            temp = Sum;
            stringMinSum = i;
        }
        else if (temp > Sum)
        {
            temp = Sum;
            stringMinSum = i;
        }
        System.Console.WriteLine($"Сумма строки №: {i} = {Sum}");
    }
    System.Console.WriteLine();
    return stringMinSum;
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = RandomArray(row, column);
PrintMatrix(matrix);
int i = MinSummElementsRow (matrix);
Console.WriteLine($"Номер строки с минимальной суммой: {i}"); 