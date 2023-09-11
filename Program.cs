// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Задача 54. Упорядочивание по возрастанию двумерного массива");
Console.WriteLine("Введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers54 = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers54);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers54);

for (int i = 0; i < numbers54.GetLength(0); i++)
{
    for (int j = 0; j < numbers54.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers54.GetLength(1) - 1; z++)
        {
            if (numbers54[i, z] < numbers54[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
            {
                int temp = 0;
                temp = numbers54[i, z];
                numbers54[i, z] = numbers54[i, z + 1];
                numbers54[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers54);

void FillArrayRandomNumbers(int[,] array54)
{
    for (int i = 0; i < array54.GetLength(0); i++)
    {
        for (int j = 0; j < array54.GetLength(1); j++)
        {
            array54[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array54)
{
    for (int i = 0; i < array54.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array54.GetLength(1); j++)
        {
            Console.Write(array54[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine(" ");
Console.WriteLine("Задача 56. Поиск строки прямоугольного двумерного массива с наименьшей суммой элементов");
Console.WriteLine("введите размер квадратного массива");
int massVol56 = Convert.ToInt32(Console.ReadLine());
int[,] numbers56 = new int[massVol56, massVol56];
FillArrayRandomNumbers56(numbers56);
PrintArray56(numbers56);
int minsum56 = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers56.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers56.GetLength(1); j++)
    {
        sum = sum + numbers56[i, j];        
    }
    if (sum < minsum56
)
    {
        minsum56
     = sum;
        indexLine++;
    }
}

Console.WriteLine("строка с наименьшей суммой элементов под номером: " + (indexLine) + ", с суммой элементов равной: " + (minsum56));

void FillArrayRandomNumbers56(int[,] array56)
{
    for (int i = 0; i < array56.GetLength(0); i++)
    {
        for (int j = 0; j < array56.GetLength(1); j++)
        {
            array56[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray56(int[,] array56)
{
    for (int i = 0; i < array56.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array56.GetLength(1); j++)
        {
            Console.Write(array56[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine(" ");
Console.WriteLine("Задача 58. Поиск произведения двух матриц");
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers58(int[,] array58)
{
    for (int i = 0; i < array58.GetLength(0); i++)
    {
        for (int j = 0; j < array58.GetLength(1); j++)
        {
            array58[i, j] = new Random().Next(1, 9); 
        }
    }
}

void PrintArray58(int[,] array58)
{
    for (int i = 0; i < array58.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array58.GetLength(1); j++)
        {
            Console.Write(array58[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumbers58(matrixA);
FillArrayRandomNumbers58(matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray58(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray58(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray58(matrixC);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine(" ");
Console.WriteLine("Задача 60. Программа на построчный вывод массива с добавлением идексов каждого элемента");
int deep1 = InputInt60("Введите размерность 1: ");
int deep2 = InputInt60("Введите размерность 2: ");
int deep3 = InputInt60("Введите размерность 3: ");
int countNums = 89;

if (deep1 * deep2 * deep3 > countNums)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

for (int i1 = 0; i1 < resultNums.GetLength(0); i1++)
{
    for (int j1 = 0; j1 < resultNums.GetLength(1); j1++)
    {
        for (int k1 = 0; k1 < resultNums.GetLength(2); k1++)
        {
            Console.WriteLine($"[{i1},{j1},{k1}] - {resultNums[i1, j1, k1]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num
     = 10;
    for (int i1 = 0; i1 < values.Length; i1++)
        values[i1] = num
        ++;

    for (int i1 = 0; i1 < values.Length; i1++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i1];
        values[i1] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i1 = 0; i1 < array.GetLength(0); i1++)
    {
        for (int j1 = 0; j1 < array.GetLength(1); j1++)
        {
            for (int k1 = 0; k1 < array.GetLength(2); k1++)
            {
                array[i1, j1, k1] = values[valueIndex++];
            }
        }
    }
    return array;
}


int InputInt60(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine(" ");
Console.WriteLine("Задача 62. Создание спирального массива 4 на 4");
Console.WriteLine("Введите размер массива");
int size62 = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size62, size62];

int num = 1;
int i3 = 0;
int j3 = 0;

while (num <= size62 * size62)
{
    nums[i3, j3] = num;
    if (i3 <= j3 + 1 && i3 + j3 < size62 - 1)
        ++j3;
    else if (i3 < j3 && i3 + j3 >= size62 - 1)
        ++i3;
    else if (i3 >= j3 && i3 + j3 > size62 - 1)
        --j3;
    else
        --i3;
    ++num;
}

PrintArray62(nums);

void PrintArray62(int[,] array62)
{
    for (int i3 = 0; i3 < array62.GetLength(0); i3++)
    {
        Console.Write("[ ");
        for (int j3 = 0; j3 < array62.GetLength(1); j3++)
        {
            Console.Write(array62[i3, j3] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
