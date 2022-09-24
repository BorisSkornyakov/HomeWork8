// Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Номер строки с наименьшей суммой элементов: 1 строка
// (допускается указывать индекс строки в массиве, в данном примере - 0)

int DataEntry(string message)
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[,] arr)
{
	Random rnd = new Random();
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = rnd.Next(1, 10);
		}
	}
}
void PrintArray(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write(arr[i, j]);
		}
		System.Console.WriteLine();
	}
	System.Console.WriteLine();
}
int SumOFString(int[,] arr, int i)
{
	int sum = 0;
	for (int j = 0; j < arr.GetLength(1); j++)
	{
		sum = sum + arr[i, j];
	}
	return sum;
}

int SearchStringWithMinSum(int[,] arr)
{
	int strnumber = 0;
	int temp = SumOFString(arr, 0);

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		if (SumOFString(arr, i) < temp)
		{
			temp = SumOFString(arr, i);
			strnumber = i;
		}
	}
	return strnumber;
}

System.Console.WriteLine("Введите размер массива");
int strCount = 0;
int colCount = 0;
int result = 0;
strCount = DataEntry("Введите количество строк ");
colCount = DataEntry("Введите количество столбцов ");
int[,] array = new int[strCount, colCount];
FillArray(array);
PrintArray(array);
result = SearchStringWithMinSum(array);
System.Console.WriteLine($"Номер строки с наименьшей суммой -> {result + 1}");
