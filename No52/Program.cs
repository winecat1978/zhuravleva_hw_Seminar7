// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string ValueFromConsole = Console.ReadLine();
        if (int.TryParse(ValueFromConsole, out int num))
        {
            return num;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Попробуйет еще раз!");
        }
    }
}

void FillArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void AverageCounter(int [,] matrix, int n)
{
    int count;
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        count = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            count+=matrix[i,j];
        }
        Console.Write($"\t{(double)count/matrix.GetLength(0),3:N1}");
    }
}

string message1 = "Введите количество строк: ";
string message2 = "Введите количество рядов: ";
int m = GetNumber(message1);
int n = GetNumber(message2);

int[,] matrix = new int[m,n];

FillArray(matrix);
PrintArray(matrix);
AverageCounter(matrix,n);