//Problem 6. Sum integers• You are given a sequence of positive integer values written into a string, separated by spaces.
//• Write a function that reads these values from given string and calculates their sum.
//Example:
//input
//output
//"43 68 9 23 318" 461 

using System;
using System.Collections.Generic;
using System.Text;



class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Please, enter integer numbers separated by spaces");
        string text = Console.ReadLine();
        string[] array = text.Split(new char[] { ' ', '"' }, StringSplitOptions.RemoveEmptyEntries);
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += int.Parse(array[i]); 
        }
        Console.WriteLine(sum);
    }
}
