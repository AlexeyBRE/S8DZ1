// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[n, m];
int temp=0;
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {

        num[i, j] = new Random().Next(1, 100);
        Console.Write($"   {num[i, j]}");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
    for (int k = 0; k < num.GetLength(0)-1; k++)
    {
        if(num[i,j]<num[i,k+1])
        {
            temp=num[i,k+1];
            num[i,k+1]=num[i,k];
            num[i,k]=temp;
        }    
    }  
    Console.Write($"   {num[i,j]}"); 
    }
    Console.WriteLine();
}
