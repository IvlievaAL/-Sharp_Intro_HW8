/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
System.Console.WriteLine("Enter number of rows: "); 
int M = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter number of columns: "); 
int N = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter maximal number: "); 
int MaxValue = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter minimal number: "); 
int MinValue = Int32.Parse(System.Console.ReadLine());
int [,] Matrix= Get2DArray(M,N,MaxValue,MinValue);
Print2DArray (Matrix);
System.Console.WriteLine(); // отступ на 1 строку
int DifferenceOfProgression=1; //с каким шагом по индексу брать элементы для обмена
Matrix=ToOrderEachRowFromMaxToMin (Matrix);
Print2DArray (Matrix);

int [,] ToOrderEachRowFromMaxToMin (int [,] Matrix)
{
    int i=0; //Поставить машину на нулевой элемент по строке.
    int j=0; //Поставить машину на нулевой элемент по столбцу.
    int temp=0; //временная переменная для перестановки двух чисел местами.
    for (;i<Matrix.GetLength(0);i++) //Проверить, прошли ли мы все строки
    { 
     for (;j<Matrix.GetLength(1)-1;j++) //Проверить, дошли ли мы до последнего элемента строки - который не надо ни с чем сравнивать.
     {
      //int step = HowManyStepsFromThisElementToLast (Matrix, j, DifferenceOfProgression);
      //System.Console.WriteLine(step);
      for (int HowManySteps=1; HowManySteps<(Matrix.GetLength(1)-j);HowManySteps++) //Элемент, на котором стоим, сравниваем поочередно с каждым следующим на строке.
       {
        System.Console.WriteLine(HowManySteps);
        if (Matrix[i,j+HowManySteps]>Matrix[i,j])
         {
          temp = Matrix[i,j+HowManySteps];
          Matrix[i,j+HowManySteps]=Matrix[i,j];
          Matrix[i,j]=temp;
          System.Console.WriteLine("смена");
         }
       }
         System.Console.WriteLine("столбцы все пройдены");
      }
      System.Console.WriteLine("строка вся пройдена");
      j=0; //переставляем машину на нулевой по столбцу элемент
     }
return Matrix; 
}

/*int HowManyStepsFromThisElementToCurrentSecondElementOfComparedPair(int [,] Matrix, int j, int DifferenceOfProgression)
{
int HowManySteps=0;
int count=0;
 while (HowManySteps<(Matrix.GetLength(1)-1))
 {
  HowManySteps = HowManySteps+count;
 }
 return HowManySteps;
}*/

int [,] Get2DArray (int M, int N, int MaxValue, int MinValue)
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