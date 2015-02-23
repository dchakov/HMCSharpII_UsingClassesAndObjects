//Problem 1. Leap year• Write a program that reads a year from the console and checks whether it is a leap one.
//• Use  System.DateTime .

using System;

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Please,enter a year");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
                       
        Console.WriteLine("{0} {1}",year,(isLeap ? "IS LEAP":"IS NOT LEAP"));
    }
}