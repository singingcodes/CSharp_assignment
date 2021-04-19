using System;

namespace Sum_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
                int n = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("Kindly enter another number");
                int m = Convert.ToInt32(Console.ReadLine());
                if (n + m < 100){
                    Console.WriteLine("true");
                } else{
                    Console.WriteLine("false");
                }
        }
    }
}
