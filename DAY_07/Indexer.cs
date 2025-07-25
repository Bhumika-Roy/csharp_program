/*using System;

public class Employee
{
    public int id { get; set; }
    public string name { get; set; }

    public Employee(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public Object this[int index]
    {
        get
        {
            return index switch
            {
                0 => id,
                1 => name,
                _ => null,
            };
        }
        set
        {
            if (index == 0) id = Convert.ToInt32(value);
            else if (index == 1) name = value.ToString();
        }
    }
}*/

/*public class MainProgram
{
    public static void Main()
    {
        Employee e = new Employee(101, "Niti");
        Console.WriteLine(e[1]); // Should print: Niti

        if (int.TryParse("12", out int value))
            Console.WriteLine("Value is " + value);
    }
}*/
