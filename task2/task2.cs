// Задать двумерный массив 
// Найти элементы у которых оба индекса четные 
// Заменить элементы этого индекса на квадраты этих элементов 


// Найти четный элемент можно разделить % 2. Если остаток 0, то число - ЧЕТНОЕ!

void FindEven (int [,] evenFind)
{
    int length = evenFind.Length;
    int i = 0;
    for (i = 0; i < evenFind.GetLength(0); i++)
    {
        for (int j = 0; j < evenFind.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
            {
                evenFind[i, j] = evenFind[i, j] * evenFind[i , j];
                Console.WriteLine($"{"Квадрат элемента массива с индексом"} {(i, j)}{":"} {evenFind[i, j]}");
            }
        }
        Console.WriteLine();
    }
}

void PrintArr (int [,] print)
{
    int length = print.Length;
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write($"{print[i , j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int [,] fill)
{
    int length = fill.Length;
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            fill[i, j] = new Random().Next(1,11);
        }
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
FillArray(numbers);
PrintArr(numbers);
FindEven(numbers);