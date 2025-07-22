using System;

namespace Program
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Calculations C = new Calculations();
            Console.WriteLine("Welcome to the calculator app");
            C.Display(); // Calls a method from Calculations class
        }
    }
}
