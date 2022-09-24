// Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int DataEntry(string message)							//Метод ввода данных
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[,] arr)								//Метод заполнения массива
{
	Random rnd = new Random();
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = rnd.Next(1, 6);
		}
	}
}
void PrintArray(int[,] arr)								//Метод печати массива
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write($"{arr[i, j]}, ");
		}
		System.Console.WriteLine();
	}
	System.Console.WriteLine();
}
int CellFromMatrixMultiplication(int[,] arrayA, int[,] arrayB, int numString, int numColumn)		//Метод вычесления значений ячейки
{																									//матрици в результате умножения матриц
	int result = 0;
	for (int i = 0; i < arrayA.GetLength(0); i++)
	{
		result = result + arrayA[numString, i] * arrayB[i, numColumn];
	}
	return result;
}
void MatrixMultiplication(int[,] arrC, int[,] arrA, int[,] arrB)								//Метод умножения матриц
{
	for (int i = 0; i < arrC.GetLength(0); i++)
	{
		for (int j = 0; j < arrC.GetLength(1); j++)
		{
			arrC[i, j] = CellFromMatrixMultiplication(arrA, arrB, i, j);
		}
	}
}
int sizeArr = DataEntry("Введите размер матриц -> ");
int[,] numbersA = new int[sizeArr, sizeArr];
int[,] numbersB = new int[sizeArr, sizeArr];
int[,] numbersC = new int[sizeArr, sizeArr];
FillArray(numbersA);
FillArray(numbersB);
PrintArray(numbersA);
PrintArray(numbersB);
MatrixMultiplication(numbersC, numbersA, numbersB);
PrintArray(numbersC);