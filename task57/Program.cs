// сосотавить частотный словарь элементов двумерного массива
// частотный словарь содержит информацию о том, сколько раз встречается 
// элемент входных данных от 0 до 9
// 1 2 3
// 4 6 1
// 2 1 6
// 1 встречается 3 раза
// 2 встречается 2 раза
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int[,] FillMatrixWithRandom(int row, int column)
{
int[,] matrix = new int[row, column];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(1, 10);
}
}
return matrix;
}



int[] Finder(int[,] matrix)
{
    int[] temp = new int [10];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp[matrix[i, j]]++;
            }               
        }
        //Console.WriteLine(String.Join(" "temp));
        return temp;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write(matrix[i, j] + " ");
}
Console.WriteLine();
}
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
int[] IndexArray = Finder(matrix);
for(int i = 0; i < IndexArray.Length; i++)
{
    if(IndexArray[i] != 0)
    {
        Console.WriteLine($"Число {i} встречается {IndexArray[i]} раз");
    }
}


