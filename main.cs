// Created by: Youngwook
// Created on: NOV 2022
//
// This function gets lengths of three side of triangle to answer properly

using System;

class Program
{
    public static void Main(string[] args)
    {
        // input
        int a;
        int b;
        int c;

        Console.WriteLine("TThis program gets lengths of three side of triangle to answer properly.\n");

        Console.Write("Enter lengths of fisrt side : "); a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter lengths of second side : "); b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter lengths of third side : "); c = Convert.ToInt32(Console.ReadLine());

        // output
        if ((a+b<=c)|| (b+c<=a) || (c+a<=b) || (a<=0) || (b<=0) || (c<=0)) 
        {
            Console.WriteLine("\nIt is not a triangle.");
        }
        else 
        {
            if ((a==b)&&(b==c)&&(c==a)) 
            {
                Console.WriteLine("\nIt is a equilateral triangle");
            }
            else if ((a==b)||(b==c)||(c==a))
            {
                Console.WriteLine("\nIt is a isosceles triangle");
            }
            else
            {
                Console.WriteLine("\nIt is a scalene triangle");
            }
        }
        Console.WriteLine("\ndone.");
    }
}
