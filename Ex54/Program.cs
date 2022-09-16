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
        for (int j = 0; j < table.GetLength(1) - 1; j++)
        {
          

               int number = 0;
               for (int l = 0; l < lineinmassive; l++)
               {
                if(table[i,j] < table[i,j+1])
                {

                    number = table[i,j];
                    table[i,j] = table[i,j+1];
                    table[i,j+1] = number;
                }
               }

            //  int number = 0;
            //    for (int l = 0; table[i,j] < table[i,j+1]; l++)
            //    {
            //     if(table[i,j] < table[i,j+1])
            //     {

            //         number = table[i,j];
            //         table[i,j] = table[i,j+1];
            //         table[i,j+1] = number;
            //     }
            //    }
            //Console.Write($" {table[i,j]} ");
        }
    }
    Console.WriteLine("");

    return table;
}

