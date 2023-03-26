// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int [,,] ThreeMatrix (int Row, int Column, int List)
{
  int [,,] ThreeMatrix = new int [Row, Column, List];
  int sizeArrayExclusive = Row * Column * List;
  int firstValueRandom = 10;
  int lastValueRandom = 99;   
  int numberGeneretionRange = lastValueRandom - firstValueRandom;
  if (sizeArrayExclusive >= numberGeneretionRange)
  {
    System.Console.WriteLine("Количество элементов массива превышает размер диапазона случайных чисел!");
    return ThreeMatrix;
  }
  Random rnd = new Random();
  bool checkingMatch=false;
  int tempRandom = 0;
  for (int i = 0; i < Row; i++)
  {
    for (int j = 0; j < Column; j++)
    {
      for (int k = 0; k < List;)
      {
        tempRandom = rnd.Next(firstValueRandom,lastValueRandom);
        checkingMatch = false;
        for (int l = 0; l < i+1;)
        {
          for (int m = 0; m < Column;)
          {
            for (int n = 0; n < List;)
            {
              
              if (ThreeMatrix [l,m,n] == tempRandom)
              {
                checkingMatch = true;
                break;
              }
              n++;
            }
            if (checkingMatch)
            break;
            m++;
          }
          if (checkingMatch)
          break;
          l++;
        }
        if (!checkingMatch)
        {
          ThreeMatrix[i,j,k] = tempRandom;
         
          k++;
        }
      } 
    }  
  }
  return ThreeMatrix;
}


void ShowThreeMatrix (int [,,] ThreeMatrixIn)
{
  for (int i = 0; i < ThreeMatrixIn.GetLength(0); i++)
  {
      for (int j = 0; j < ThreeMatrixIn.GetLength(1); j++)
      {
        for (int k = 0; k < ThreeMatrixIn.GetLength(2); k++)
        {
          System.Console.Write($"{ThreeMatrixIn[i,j,k]}({i},{j},{k})\t");
        }
        System.Console.WriteLine();
      }
      System.Console.WriteLine();
  }
}


Console.WriteLine("Введите количество строк трехмерного массива");
int Row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов трехмерного массива");
int Column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество листов трехмерного массива");
int List = Convert.ToInt32(Console.ReadLine());
int [,,] CreatingThreeMatrix = ThreeMatrix (Row, Column, List);

System.Console.WriteLine("Ваша матрица заполнена случайными исключительными числами в диапазоне от 10 до 90:");
ShowThreeMatrix(CreatingThreeMatrix);