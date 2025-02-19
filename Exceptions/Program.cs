 using System;

class Program
 {
 static void Main(string[] args)
    {
       int x;
       int y;
       int result;

       try
       {
       Console.WriteLine("Give number x: ");
       x = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine("Give number y: ");
       y = Convert.ToInt32(Console.ReadLine());

       result = x/y;
       Console.WriteLine("Result is: " +result);
       }
       catch(FormatException e)
       {
        Console.WriteLine("Enter only numbers!");
       }
       catch(DivideByZeroException e)
       {
        Console.WriteLine("This is impossible!!!");
       }
       finally
       {
        Console.WriteLine("That is all.");
       }
    }
 }