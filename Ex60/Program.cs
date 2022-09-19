

// int  a2 ;
// int[,,] mas1 = new int[3,3,3];
// Random p = new Random();

// //int[,,] minimas = new int[3, 3, 3];
// int k = 0;
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 3; j++)
//     {
//         for (int l = 0; l < 3; l++)
//         {
//         a2 = p.Next(1, 28);

//                 for (int q = 0; q < 3; q++)
//                     for (int w = 0; w < 3; w++)
//                         for(int m=0; m<3;m++)
//                         if (a2 != mas1[q, w,m])
//                         {
//                             k++;
//                         }



//         if (k == 27)
//         {
//             mas1[i, j,l] = a2;
//             k = 0;
//         }
//         else
//         {
//             k = 0;
//             j = (j - 1);
//             continue;
//         }



//         Console.Write(mas1[i, j,l] + "  ");
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine();
// }


Console.WriteLine("Введите количество столбцов в массиве: ");
bool line = int.TryParse(Console.ReadLine(), out int columninmassive);
Console.WriteLine("Введите количество строк в массиве: ");
bool column = int.TryParse(Console.ReadLine(), out int lineinmassive);
Console.WriteLine("Введите высоту в массиве: ");
bool height = int.TryParse(Console.ReadLine(), out int heightmassive);

if (!line || !column || !height || columninmassive < 1 || lineinmassive < 1 || heightmassive < 1)
{
    Console.WriteLine("Не верные введённые данные, попробуйте поменять значение.");
}

int[,,] doublemassive = new int[lineinmassive, columninmassive, heightmassive];
int[,,] resultmassive = NewDoubleMassive(doublemassive);
PrintMassive(resultmassive);


int[,,] NewDoubleMassive(int[,,] table)
{
    int k = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            for (int l = 0; l < table.GetLength(2); l++)
            {
                //table[i, j, l] = new Random().Next(1, 10);
                int a = new Random().Next(1, 50);
                int b = table.GetLength(0) * table.GetLength(1) * table.GetLength(2);
                for (int v = 0; v < i; v++)
                {
                    for (int n = 0; n < j; n++)
                    {
                        for (int m = 0; m < l; m++)
                        {
                            if (a != table[v,n,m])
                            {
                                k++;
                            }
                            if (k == b)
                            {
                                table[i, j, l] = a;
                                k = 0;
                            }
                            else
                            {
                                k = 0;
                                j = (j - 1);
                                continue;
                            }
                        }
                    }
                }
            }
        }

    }
    return table;
}




void PrintMassive(int[,,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < table.GetLength(1); j++)
        {
            for (int l = 0; l < table.GetLength(2); l++)
            {
                Console.Write($"  {table[i, j, l]}  ");
            }
        }
        Console.WriteLine("]");
    }
}
