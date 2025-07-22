using System;

namespace Program
{
    public class Calculations
    {
        public void Display()
        {
            Console.WriteLine("Select Operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            Console.Write("Enter choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool valid = true;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                         result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Error: Division by zero!");
                        valid = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    valid = false;
                    break;
            }

            if (valid)
                Console.WriteLine($"Result: {result}");
        }
    }
}