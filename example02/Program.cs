// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, изначально массив
 //выглядел вот так:
//1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Новый массив будет выглядеть 
//вот так:
//1 4 7 2
//5 81 2 9
// 8 4 2 4

int GetConsole(string msg, int x)
{
    int result;

    while (true)
    {
        void LogWrong(string err)
        {
            Console.WriteLine(err);
        }

        Console.Write(msg);

        string str = Console.ReadLine() ?? "";

        if (int.TryParse(str, out int number) && number > x)
        {
            result = number;
            break;
        }
        else
        {
            LogWrong($"Нужно число > {x}.\n");
        }
    }

    return result;
}

int[,] InitArray(int m, int n)
{
    Random rnd = new Random();
    int b;
    int[,] arr = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            b = rnd.Next(-9, 10);
            arr[i,j] = b;
        }
    }
    return arr;
}
void Change(int[,] arr, int m, int n)
{
    for (int i = 1; i < arr.GetLength(0); i+=2)
    {
        for (int j = 1; j < arr.GetLength(1); j+=2)
        {
                arr[i,j] = Convert.ToInt32(Math.Pow(arr[i,j],2));
        }
    }
}

void Vivod(int[,] arr, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {   
            if(j!=n-1){
                Console.Write($"{arr[i,j]} ");
            }else{
                Console.Write($"{arr[i,j]}\n");
            }
        }
    }
}

int m = GetConsole("Введите m: ", 0); //10
int n = GetConsole("Введите n: ", 0); //10
int[,] arr = InitArray(m, n);
Change(arr, m, n); //10
Vivod(arr, m, n); //10
