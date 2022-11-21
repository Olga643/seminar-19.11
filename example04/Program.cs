/*
Задача 53:
Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

int GetNumber(string msg)
{
    Console.Write(msg);
}
int[,] ChangeArray(int[,] array, int m, int n)
{
int [,] tempArray = new int[m,n];
    
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            if(i == 0)
            tempArray[i, j] = array[m - 1, j];
            else if(i == (tempArray.GetLength(0) - 1))
            tempArray[i, j] = array[0, j];
            else
            tempArray[i, j] = array[i, j];
        }   
    }

    return tempArray;
}


int m = GetNumber("Введите число строк: ");
int n = GetNumber("Введите число столбцов: ");
int[,] firstArray = InitArray(m, n);
PrintArray(firstArray);
Console.WriteLine();
int[,] newArray = ChangeArray(array: firstArray, m, n);
PrintArray(newArray);
