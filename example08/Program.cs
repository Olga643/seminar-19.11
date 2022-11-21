// Задача 59: Задайте двумерный массив из целых чисел.
//  Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] InitMatrix(int m, int n)
{
    Random rnd = new Random();
    int[,] mtrx = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mtrx[i,j] = rnd.Next(0,10);
        }
    }
    return mtrx;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i,j]}  ");
        }
        Console.WriteLine();
    }
}
int[] FindMinOfMatrix(int[,] mtrx)
{
    int minElement = mtrx[0,0];
    int[] min = new int[2]{0,0};
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if(mtrx[i,j]<minElement)
            {
                minElement = mtrx[i,j];
                min[0] = i;
                min[1] = j;
            }       
        }
    }
    return min;
}
int[,] ResultMatrix(int[,] mtrx, int[] pos)
{
    int countI = 0;
    int countJ = 0;
    int[,] resultMatrix = new int[mtrx.GetLength(0)-1,mtrx.GetLength(1)-1];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        if(i != pos[0])
        {
            for (int j = 0; j < mtrx.GetLength(1); j++)
            {
                if(j != pos[1])
                {
                    resultMatrix[countI,countJ] = mtrx[i,j];
                    countJ++;
                }
            }
            countJ=0;
            countI++;
        }
    }
    return resultMatrix;
}
Console.WriteLine("Введите кол-во строк матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = InitMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();
int[] posMin = FindMinOfMatrix(matrix);
int[,] resultMtrx = ResultMatrix(matrix, posMin);
PrintMatrix(resultMtrx);