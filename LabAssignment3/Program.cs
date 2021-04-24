using System;

namespace LabAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Hey there Welcome");
            Console.WriteLine("This program will help you solve remainder problems");
		    Console.Write("Enter first number:");
		    x = int.Parse(Console.ReadLine());
		    Console.Write("Enter second number:");
		    y = int.Parse(Console.ReadLine());
            z = x % y;
            Console.WriteLine($"The Remainder is: {z}");
            Console.WriteLine("yeeeepiii!!!!");


        }
    }
}
