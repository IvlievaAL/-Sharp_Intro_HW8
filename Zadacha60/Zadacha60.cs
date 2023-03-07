/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

//сам код
int [,,] Array3D = Get3DArrayOfDimensionsFromConsoleFilledWithTwoDigitsNumbers();
Print3DArrayByRows(Array3D);

//список функций

void Print3DArrayByRows (int [,,] Array3D) /*Этот метод, судя по примеру, движется по массиву другим образом.
Сначала нужно перебрать все ячейки по y до упора; затем перейти на следующий x и перебрать его y, и так для каждого x;
 только потом уже переместиться на следующий z и перебрать все его x по y, и т.д. для каждого z*/
{
 for (int z=0; z<Array3D.GetLength(2); z++)
 {
  for (int x=0; x< Array3D.GetLength(0); x++)
  {
   for (int y=0; y<Array3D.GetLength(1);y++)
   {
    System.Console.Write($"{Array3D[x,y,z]}({x},{y},{z}) ");
   }
   System.Console.WriteLine();
  }
 }
}

/*Как этот метод движется по массиву. 
Начиная с нулевого по всем трем индексам элемента, перебор ячеек по z до упора.
Затем переход на следующий y и перебор ячеек по z до упора; и так для каждого y.
Затем переход на следующий x, перебор всех его y по z, и так для каждого x*/
int [,,] Get3DArrayOfDimensionsFromConsoleFilledWithTwoDigitsNumbers() 
{
 System.Console.WriteLine("Введите размер массива по оси x");
 int X=Convert.ToInt32(System.Console.ReadLine());
 System.Console.WriteLine("Введите размер массива по оси y");
 int Y=Convert.ToInt32(System.Console.ReadLine());
 System.Console.WriteLine("Введите размер массива по оси z");
 int Z=Convert.ToInt32(System.Console.ReadLine());
 if (X<=0 | Y<= 0| Z<=0)
 {
  System.Console.WriteLine("Array size must be positive number");
  int [,,] ZeroArray= new int [1,1,1];
  return ZeroArray;
 }
 else 
 {
  if (X*Y*Z<100)
  {
   int [,,] ArrayOfTwoDigitsNumbers3D = new int [X,Y,Z];
   int count=0;
   for (int x=0; x< ArrayOfTwoDigitsNumbers3D.GetLength(0); x++)
   {
    for (int y=0; y<ArrayOfTwoDigitsNumbers3D.GetLength(1);y++)
    {
     for (int z=0; z<ArrayOfTwoDigitsNumbers3D.GetLength(2); z++)
     {
      ArrayOfTwoDigitsNumbers3D[x,y,z]= 10+count;
      count++;
     }
    }
   }
   return ArrayOfTwoDigitsNumbers3D;
  }
  else 
  {
   System.Console.WriteLine("This array is bigger than the amount of two-digits numbers without repeats");
  int [,,] ZeroArray= new int [1,1,1];
  return ZeroArray;
  }
 }
}