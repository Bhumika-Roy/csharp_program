using System;

class CampusCanteenCouponTracker
{
    static void Main()
    {
        // Input phase
        Console.Write("Enter number of coupons: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 100)
        {
            Console.WriteLine("Number of coupons must be between 1 and 100.");
            return;
        }

        int[] coupons = new int[n];

        Console.WriteLine("Enter coupon values, separated by spaces:");
        string[] inputs = Console.ReadLine().Split(' ');

        if (inputs.Length != n)
        {
            Console.WriteLine($"Error: You entered {inputs.Length} values but expected {n}.");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            coupons[i] = int.Parse(inputs[i]);
        }
// Processing phase
        int totalValue = 0;
        int highestValue = coupons[0];
        int highestPosition = 1; // 1-based index
        int smallCount = 0, mediumCount = 0, largeCount = 0;

        for (int i = 0; i < n; i++)
        {
            int value = coupons[i];
            totalValue += value;

            if (value > highestValue)
            {
                highestValue = value;
                highestPosition = i + 1; // 1-based
            }

            // Classification
            if (value <= 50)
            {
                smallCount++;
            }
            else if (value <= 100)
            {
                mediumCount++;
            }
            else
            {
                largeCount++;
            }
        }
// Output phase
        Console.WriteLine("\n----- Daily Coupon Summary -----");
        Console.WriteLine("Total coupons redeemed  : " + n);
        Console.WriteLine("Total value collected   : " + totalValue);
        Console.WriteLine($"Highest coupon redeemed : {highestValue} (coupon #{highestPosition})\n");

        Console.WriteLine("Category breakdown");
        Console.WriteLine($"Small  (≤50)   : {smallCount}");
        Console.WriteLine($"Medium (51-100): {mediumCount}");
        Console.WriteLine($"Large  (>100)  : {largeCount}");
    }
}