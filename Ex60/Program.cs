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
GetArray(doublemassive);
PrintArray(doublemassive);
int[,,] GetArray(int[,,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
             int k = 0;
            while (k < result.GetLength(2))
            {
                int element = new Random().Next(10,100);
                if (FindElement(result, element)) continue;
                result[i, j, k] = element;
                k++;
                }
            }
        }
         return result;
    }

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}