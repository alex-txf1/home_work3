﻿Console.WriteLine("вывести куб числа");
Console.WriteLine("_______________________________");
Console.Write("введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
int[] A = new int[num];
for(int i = 1; i <= num; i++)
{
    A[i-1] = i * i * i;
    Console.WriteLine(A[i-1]);
}

