Console.Write("Введите число для которого будет применено спиральное заполнение: ");
bool number = int.TryParse(Console.ReadLine(), out int n);
if (!number || n <= 0)
{
    Console.WriteLine("Не верные введённые данные, попробуйте поменять значение.");
}

int[,] a = new int[n, n];
Massive(n,a);
DisplayMassive(a);

void DisplayMassive(int[,] a)
{
     Console.WriteLine();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++) 
        Console.Write("{0,3} ", a[i, j]);
        Console.WriteLine();
    }
}
int Massive(int n, int[,] a)
{
        int i = 0, j = 0;

        int value = 1;

        while (n != 0)
        {
            int k = 0;
            do { a[i, j++] = value++; } while (++k < n - 1);
            for (k = 0; k < n - 1; k++) a[i++, j] = value++;
            for (k = 0; k < n - 1; k++) a[i, j--] = value++;
            for (k = 0; k < n - 1; k++) a[i--, j] = value++;

            ++i; ++j; n = n < 2 ? 0 : n - 2;
        }
    return a[i,j];
}

