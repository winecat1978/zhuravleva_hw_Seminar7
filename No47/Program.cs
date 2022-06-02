// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int GetNumber (string msg)
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

void FillArray(double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().NextDouble();
        }
    }
}

void PrintArray(double [,] matrix)
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

string message1 = "Введите количество строк: ";
string message2 = "Введите количество рядов: ";
int m = GetNumber(message1);
int n = GetNumber(message2);

double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);