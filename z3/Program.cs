// Напишите программу, которая задаёт массив из N элементов и выводит их на экран


using System;

public class Program
{
    public static void Main()
    {
        int number = 233411;
        string Number = Convert.ToString(number);
        Console.WriteLine(Number);
        int[] Array = new int[Number.Length];
        int i;

        for(i = 0; i < Number.Length; i++)
        {
            Array[i] = Convert.ToInt32(Number[i].ToString());
            Console.Write(Array[i] + " ");
        }

    }
}