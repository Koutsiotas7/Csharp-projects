using System;

class Program
{
    static void Main(string[] args)
    {
        double total;

        total = Multiply(2, 3, 4);

        Console.WriteLine(total);

        double sinolo =Checkout(4 ,5.2 ,6.7 ,13.2);
        Console.WriteLine(sinolo);
    }
    
    // overloading
    static double Multiply(double a, double b)
    {
        return a*b;
    }

    static double Multiply(double a, double b, double c)
    {
        return a*b*c;
    }
    //params keyword
    static double Checkout(params double[] prices)
    {
        double total = 0;
        foreach(double price in prices)
        {
            total += price;
        }
        return total;
    }
}