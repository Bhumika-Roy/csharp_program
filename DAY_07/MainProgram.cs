using System;
public class MainProgram
{
    public static void Main()
    {
        Employee e = new Employee(101, "Niti");
        Console.WriteLine(e[1]); // Should print: Niti

        if (int.TryParse("12", out int value))
            Console.WriteLine("Value is " + value);
    }
}