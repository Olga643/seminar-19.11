// 57 задача
int[,] InitMatrix(int n, int m)
{
    Random rnd = new Random();
    int[,] matrix  = new int[n,m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i,j] = rnd.Next(1,20);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}
Dictionary<int, int> GetDictionaryFromMatrix(int[,] matrix)
{
    Dictionary<int,int> resultDic = new Dictionary<int, int>();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(resultDic.ContainsKey(matrix[i,j]))
                resultDic[matrix[i,j]] += 1; 
            else
                resultDic.Add(matrix[i,j], 1);
        }
    }

    return resultDic;
}


int[,] matrix = InitMatrix(4,4);
PrintMatrix(matrix);
Dictionary<int,int> dic = GetDictionaryFromMatrix(matrix);

foreach(var item in dic.OrderBy(x=>x.Key))
{
    Console.WriteLine($"{item.Key} встречается {item.Value} раза ");
}
