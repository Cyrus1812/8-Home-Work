Console.WriteLine("Введите количество столбцов в 1 массиве: ");
bool line = int.TryParse(Console.ReadLine(), out int columninmassive);
Console.WriteLine("Введите количество строк в 1 массиве: ");
bool column = int.TryParse(Console.ReadLine(), out int lineinmassive);
Console.WriteLine("Введите количество столбцов во 2 массиве: ");
bool line2 = int.TryParse(Console.ReadLine(), out int columninmassive2);
Console.WriteLine("Введите количество строк во 2 массиве: ");
bool column2 = int.TryParse(Console.ReadLine(), out int lineinmassive2);

if (!line || !column || columninmassive < 1 || lineinmassive < 1 || !line2 || !column2 || columninmassive2 < 1 || lineinmassive2 < 1)
{
    Console.WriteLine("Не верные введённые данные, попробуйте поменять значение.");
}

int[,] doublemassive2 = new int[lineinmassive2, columninmassive2];
int[,] doublemassive = new int[lineinmassive, columninmassive];
int[,] resultmassive = NewDoubleMassive(doublemassive);
int[,] resultmassive2 = NewDoubleMassive(doublemassive2);

 Console.WriteLine("Первый массив массив: ");
PrintMassive(resultmassive);
 Console.WriteLine("Второй массив: ");
PrintMassive(resultmassive2);
MultiplicationMassive(doublemassive,doublemassive2);


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
        Console.Write("[");
        for (int j = 0; j < table.GetLength(1); j++)
        {
            
            Console.Write($"  {table[i, j]}  ");
        }
        Console.WriteLine("]");
    }
}

void MultiplicationMassive(int[,]ar1 , int[,]ar2)
{
    
  int[,] m = new int[ar1.GetLength(0), ar2.GetLength(1)];
 
            for (int i = 0; i < ar1.GetLength(0); ++i)
            {
                for (int j = 0; j < ar2.GetLength(0); ++j)
                {
                    for (int k = 0; k < ar2.GetLength(1); ++k)
                    {
                        m[i, k] += ar1[i, j] * ar2[j, k];
                    }    
                }        
            }       
            Console.WriteLine("Произведение двух матриц равно: ");
             for (int l = 0; l < ar1.GetLength(0); ++l)
            {
                
                Console.Write("[");
                for (int n = 0; n < ar2.GetLength(1); ++n)
                {
                    Console.Write(m[l, n] + " ");
                }
                Console.WriteLine("]");
            }     
}
