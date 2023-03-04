/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int [,] Matrix= GetRectangle2DArrayFromConsole ();
System.Console.WriteLine(); // отступ на 1 строку
Print2DArray (Matrix);
System.Console.WriteLine(); // отступ на 1 строку
int [] SumsOfEachRowOf2DArray = new int [Matrix.GetLength(0)]; //Задан одномерный массив размером с количество строк нашего двумерного массива.
//сюда вывод одномерного массива
System.Console.WriteLine(); // отступ на 1 строку
System.Console.WriteLine(GetIndexOfMinimalElementOfLinearArray (SumsOfEachRowOf2DArray)); //Пока пусть покажет нужный индекс цифрой.

int GetIndexOfMinimalElementOfLinearArray (int [] SumsOfEachRowOf2DArray)
{
  int IndexOfMinimalElement=0;
  for (int i=0; i<SumsOfEachRowOf2DArray.GetLength(0); i++)
  {
   if (SumsOfEachRowOf2DArray[i+1]<SumsOfEachRowOf2DArray[i]) 
   {
    IndexOfMinimalElement=i+1;
   }
  }
  return IndexOfMinimalElement;
}

int [,] GetRectangle2DArrayFromConsole ()
{
System.Console.WriteLine("Enter number of rows: ");
int M = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter number of columns: "); 
int N = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter maximal number: "); 
int MaxValue = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter minimal number: "); 
int MinValue = Int32.Parse(System.Console.ReadLine());
if (M==1 | N==1) 
{
    System.Console.WriteLine("This array is not a rectangle");
    int[,] Array2D = new int [1,1];
    return Array2D;
}
else
{
    int[,] Array2D = new int [M,N];
    for (int i=0; i<Array2D.GetLength(0); i++)
    {
    for (int j=0; j<Array2D.GetLength(1); j++)
    {
      Array2D[i,j]= new Random().Next(MinValue, MaxValue+1);
    }
    }
    return Array2D;
}
}

void Print2DArray (int [,] Matrix)
{
for (int i=0; i<Matrix.GetLength(0); i++)
 {
    for (int j=0; j<Matrix.GetLength(1); j++)
    {
      System.Console.Write($"{Matrix[i,j]} ");
    }
    System.Console.WriteLine();
 }
}