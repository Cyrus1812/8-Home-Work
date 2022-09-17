Console.WriteLine("Введите количество столбцов в массиве: ");
bool line = int.TryParse(Console.ReadLine(), out int columninmassive);
Console.WriteLine("Введите количество строк в массиве: ");
bool column = int.TryParse(Console.ReadLine(), out int lineinmassive);

if (!line || !column || columninmassive < 1 || lineinmassive < 1)
{
    Console.WriteLine("Не верные введённые данные, попробуйте поменять значение.");
}

int[,] doublemassive = new int[lineinmassive, columninmassive];
int[,] resultmassive = NewDoubleMassive(doublemassive);
PrintMassive(resultmassive);
Console.WriteLine($"Строка с наименьшей суммой = {NewDoubleMassive2(resultmassive)}");

int[,] NewDoubleMassive(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(1, 10);
        }
    }
    return table;
}

void PrintMassive(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        int sum = 0;
        Console.Write("[");
        for (int j = 0; j < table.GetLength(1); j++)
        {
             sum += table[i, j];
            Console.Write($"  {table[i, j]}  ");
        }
        Console.Write("]");
        Console.WriteLine($" Сумма строки = {sum}");

    }
}

int NewDoubleMassive2(int[,] table)
{
    int[] mass = new int[table.GetLength(1)];
    int min=int.MaxValue;
    int index = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            sum += table[i, j];
        }
        if (sum < min)
        {
            min = sum;
            index = i + 1;
        }
    }
    return index;
}

