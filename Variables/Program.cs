using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 15;
        int y = 10;
        int z = x + y;

        Console.WriteLine("The z value is: " + z);

        double pi = 3.14;
        int ipi = Convert.ToInt32(pi);

        Console.WriteLine(ipi.GetType());  // System.Int32
        Console.WriteLine(pi.GetType());   // System.Double
        
    }
}