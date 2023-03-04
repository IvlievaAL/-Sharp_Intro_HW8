/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
/* Две части у этой задачи:
1. Сгенерить такой массив.
2.Уже что-то там по нему выводить.

Как его сгенерить:
1. С консоли ввести размеры (3 штуки) массива
2. Сгенерить свежий, с нулями, 3Д массив
3. С консоли ввести диапазон значений элементов массива от 10 до 99 или от -10 до -99
4. Проверить, правильный ли введен диапазон
5. Заполнить массив рандомными числами из этого диапазона
*/


/*System.Console.WriteLine("Enter X-dimension array size ");
int Xsize = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter Y-dimension array size "); 
int Ysize = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter Z-dimension array size "); 
int Zsize = Int32.Parse(System.Console.ReadLine());
int[,,] Array3D = new int [Xsize,Ysize,Zsize];*/
System.Console.WriteLine("Enter minimal value from 10-99 or -10--99 ranges: "); 
int MinValue = Int32.Parse(System.Console.ReadLine());
int Number = MinValue;
ToCheckIfNumberHasTwoDigits (Number);
System.Console.WriteLine("Enter maximal value from 10-99 or -10--99 ranges: "); 
int MaxValue = Int32.Parse(System.Console.ReadLine());
Number = MaxValue;
ToCheckIfNumberHasTwoDigits (Number);

void ToCheckIfNumberHasTwoDigits (int Number)
{
 int count=0; 
 int temp = Number/10;
 while (Math.Abs(temp)>0)
 {
    count++;
    temp=temp/10;
 }
 if (count == 1) 
 {
  System.Console.WriteLine("Value is correct");
 }
 else 
 {
  System.Console.WriteLine("Incorrect value");
 }
}

/*for (int i=0; i<Array2D.GetLength(0); i++)
 {
    for (int j=0; j<Array2D.GetLength(1); j++)
    {
      Array2D[i,j]= new Random().Next(MinValue, MaxValue+1);
    }
 }
 return Array2D;*/
