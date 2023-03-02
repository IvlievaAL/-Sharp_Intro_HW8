/*Задача 58. Задать 2 матрицы. Найти их произведение.

Произведением матриц А и В является такая матрица AB: 
AB[i,j] = сумма произведений элементов i-той строки матрицы А 
на соответствующие им по порядку элементы j-того столбца матрицы В.

То есть AB[i,j] = A[i,0]*B[0,j]+A[i,1]*B[1,j]+....+A[i,A.GetLenght-1]*[B.GetLenght-1,j];

Умножение матриц возможно только тогда, когда число столбцов матрицы А равно числу строк матрицы В.
Размеры их произведения АВ: число строк = число строк матрицы А, число столбцов = число столбцов матрицы В.

Разобьем программу на блоки:

1.1. Ввод в консоль параметров матриц;
1.2. Создание двух матриц;
2. Проверка возможности их перемножения;
3. Собственно их перемножение;
4. Вывод трех матриц в консоль;*/
int [,] MatrixA= Get2DArrayFromConsole (); //Создание двух матриц по вводимым с консоли параметрам
int [,] MatrixB= Get2DArrayFromConsole ();
int step=1; //шаг по индексу строк матрицы A и индексу столбцов матрицы B: которые строки и столбцы будем перемножать (в данной задаче все)
//int [,] MatrixAB= вот сюда наша функция; //Проверка возможности их перемножения+Собственно их перемножение.
int [,] Matrix = MatrixA; //Вывод трех матриц в консоль.
Print2DArray (Matrix);
System.Console.WriteLine(); // отступ на 1 строку
Matrix = MatrixB;
Print2DArray (Matrix);
System.Console.WriteLine(); // отступ на 1 строку
//int [,] Matrix = MatrixAB;
//Print2DArray (Matrix);


// Список функций.

int [,] ToMultiplyTwo2DArrays (int [,] MatrixA, int [,] MatrixB, int step)
{
      int [,] MultiplicationAB = new int [MatrixA.GetLenght(0),MatrixB.GetLenght(1)]; //Создать пустую матрицу-произведение.
    /*тут блок проверки возможности умножения
    {//если нельзя умножить
    //вывести в консоль текст об этом
    return MultiplicationAB; //вернется пустая матрица
    }*/
    {//если можно умножить

      int iAB=0; //Поставить машину на нулевой элемент AB по строке.
      int jAB=0; //Поставить машину на нулевой элемент AB по столбцу.
      for (;i<Matrix.GetLenght(0);i++) //Проверить, все ли строки AB перебраны.
      {
       for (;j<Matrix.GetLenght(1); j++) //Проверить, все ли столбцы AB перебраны.
       {

       }
      }
    return MultiplicationAB;
    }
}

int [,] Get2DArrayFromConsole ()
{
System.Console.WriteLine("Enter number of rows: ");
int M = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter number of columns: "); 
int N = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter maximal number: "); 
int MaxValue = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter minimal number: "); 
int MinValue = Int32.Parse(System.Console.ReadLine());
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