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
PrintMassive(NewDoubleMassive2(resultmassive));

int[,] NewDoubleMassive(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(1, 100);
        }
    }
    return table;
}

void PrintMassive(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"  {table[i, j]}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] NewDoubleMassive2(int[,] table)
{

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1) ; j++)
        {
               for (int l = j; l <  table.GetLength(1) ; l++)
               {
                if(table[i,j] < table[i,l])
                {
                     var number = 0;

                    number = table[i,j];
                    table[i,j] = table[i,l];
                    table[i,l] = number;
                }
               }
        }
    }
    Console.WriteLine("");
    Console.WriteLine("Массив с сортировкой в каждой строке от большего числа к меньшему равен: ");
    Console.WriteLine("");

    return table;
}

