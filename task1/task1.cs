void FillPrintArr (int [,] printFill)
{
    int length = printFill.Length;
    for (int i = 0; i < printFill.GetLength(0); i++)
    {
        for (int j = 0; j < printFill.GetLength(1); j++)
        {
            printFill[i, j] = new Random().Next(1, 10);
            Console.Write($"{printFill[i , j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
Console.WriteLine("Введите размер массива.");
Console.WriteLine();
Console.Write("Введите количество строк: ");
int userDataM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int userDataN = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [userDataM,userDataN];

Console.WriteLine();
Console.WriteLine("Созданный массив: ");
Console.WriteLine();
FillPrintArr(numbers);