// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    string ValueFromConsole = Console.ReadLine();
    if (int.TryParse(ValueFromConsole, out int num))
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели не число, попробуйте еще раз!");
    }
    return num;
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 20);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int a = 0; a < matrix.GetLength(0); a++)
    {
        for (int b = 0; b < matrix.GetLength(1); b++)
        {
            Console.Write($"{matrix[a, b]} ");
        }
        Console.WriteLine();
    }
}

void NumberChecker(int[,] matrix, int M, int N)
{
    if ((M > matrix.GetLength(0)) || (N > matrix.GetLength(1)))
    {
        Console.WriteLine("Элемента с такими индексами в массиве нет.");
    }
    for (int c = 0; c < matrix.GetLength(0); c++)
    {
        for (int d = 0; d < matrix.GetLength(1); d++)
        {
            if ((c + 1 == M) && (d + 1 == N))
            {
                Console.WriteLine($"С такими индексами в массиве есть число {matrix[c, d]}");
            }
        }
    }
}

string message1 = "Введите количество строк: ";
string message2 = "Введите количество рядов: ";
int m = GetNumber(message1);
int n = GetNumber(message2);

int[,] matrix = new int[m, n];

string messageN = "В каком ряду вы ищите число?";
string messageM = "В какой строке вы ищите число?";
int M = GetNumber(messageM);
int N = GetNumber(messageN);

FillArray(matrix);
PrintArray(matrix);
NumberChecker(matrix, M, N);