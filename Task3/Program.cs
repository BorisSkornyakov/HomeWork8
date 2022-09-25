// Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел (размер массива не более 50 элементов). 
// Напишите программу, которая будет построчно выводить массив.
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34
int DataEntry(string message)                                //Метод ввода данных
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] arr)									//Метод заполнения массива неповторяющимися элементами
{
	Random rnd = new Random();
	bool match = false;
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = rnd.Next(10, 100);
			match = GotMatch(arr, arr[i, j]);
			if(match)
			{
				j--;
			}
		}
	}
}

void PrintArray(int[,] arr)                               //Метод печати массива
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

bool GotMatch(int[,] array, int temp)                    //Метод проверки массива на повторяющиеся числа
{
	int countMatches = 0;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if (array[i, j] == temp)
			{
				countMatches++;
			}

		}
		if (countMatches > 1)
		{
			return true;
		}
	}
	return false;
}
System.Console.WriteLine("Введите размер массива");
int strCount = 0;
int colCount = 0;
strCount = DataEntry("Введите количество строк ");
colCount = DataEntry("Введите количество столбцов ");
int[,] arr = new int[strCount, colCount];
FillArray(arr);
PrintArray(arr);
