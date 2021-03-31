using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++) {
                if (num % 3 == 0 && num % 5 == 0) { //Prints out FizzBuzz if the number is a multiple of 3 and 5
                    Console.WriteLine("FizzBuzz");
                } else if (num % 5 == 0) { //Prints out Buzz if the number is a multiple of 5
                    Console.WriteLine("Buzz"); 
                } else if (num % 3 == 0) { //Prints out Fizz if the number is a multiple of 3
                    Console.WriteLine("Fizz");
                } else {
                    Console.WriteLine(num);
                }
            }
            
        }
    }
}
