// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
	// Например, задан массив:
	// 1 4 7 2
	// 5 9 2 3
	// 8 4 2 4
	// В итоге получается вот такой массив:
	// 7 4 2 1
	// 9 5 3 2
	// 8 4 4 2
	
// 	int row = 3;
// 	int col = 4;
// 	int min = 1;
// 	int max = 10;
// 	int[,] GetMatrix(int row, int col, int min, int max)
// 	{
// 	int[,] matrix = new int[row, col];
// 	for (int i = 0; i < matrix.GetLength(0); i++)
// 	{
// 	for (int j = 0; j < matrix.GetLength(1); j++)
// 	{
// 	matrix[i, j] = new Random().Next(min, max);
// 	}
// 	}
// 	return matrix;
// 	}
// 	int[,] SortRowAscending(int[,] array)
// 	{
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 	for (int j = 0; j < array.GetLength(1); j++)
// 	{
// 	int minPosition = j;
// 	for (int k = j + 1; k < array.GetLength(1); k++)
// {
// if (array[i, k] > array[i, minPosition]) minPosition = k;
// }
// int tmp = array[i, j];
// array[i, j] = array[i, minPosition];
// array[i, minPosition] = tmp;
// }

// }
// return array;
// }
// void PrintTable(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// Console.Write(matrix[i, j] + " ");
// }
// Console.WriteLine();
// }
// }


// int[,] table = GetMatrix(row, col, min, max);
// PrintTable(table);
// Console.WriteLine();
// int[,] rowSort = SortRowAscending(table);
// PrintTable(rowSort);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int row = 4;
// int col = 4;
// int min = 1;
// int max = 10;
// int[,] GetMatrix(int row, int col, int min, int max)
// {
// int[,] array = new int[row, col];
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = new Random().Next(min, max);
// }
// }
// return array;
// }
// int rowNumber(int[,] array)
// {
// int index = 0;
// int sum = 0;
// int result = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
// sum = 0;
// for (int j = 0; j < array.GetLength(1); j++)
// {
// sum += array[i, j];
// }
// if (i == 0) result = sum;
// else if (sum < result)
// {
// result = sum;
// index = i;
// }
// }
// return index + 1;
// }
// void PrintMatrix(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i, j] + " ");
// }
// Console.WriteLine();
// }
// }
// int[,] matrix = GetMatrix(row, col, min, max);
// PrintMatrix(matrix);
// Console.WriteLine();
// int index = rowNumber(matrix);
// Console.WriteLine($"Наименьшая сумма элементов в {index} строке");



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int row = 2;
int col = 2;
int[,] matrix1 = CreateMatrix(row, col, 1, 10);
int[,] matrix2 = CreateMatrix(row, col, 1, 10);
int[,] product = MultiplyMatrix(matrix1, matrix2);

int[,] CreateMatrix(int row, int col, int min, int max)
{
int[,] matrix = new int[row, col];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(min, max);
}
}
return matrix;
}
int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
int[,] product = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
for (int j = 0; j < matrix2.GetLength(1); j++)
{
product[i, j] = matrix1[i, j] * matrix2[i, j];
}
}
return product;
}
void PrintMatrix(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(" " + array[i, j] + " ");
}
Console.WriteLine();
}
}
PrintMatrix(matrix1);
Console.WriteLine(" ----");
PrintMatrix(matrix2);
Console.WriteLine(" _____");
PrintMatrix(product);
