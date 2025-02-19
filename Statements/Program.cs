using System;

class Program
{
    static void Main()
    {
        /*
        Console.WriteLine("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >=18)
        {
            Console.WriteLine("You are old enough to drive.");
        }
        else if (age < 18)
        {
            Console.WriteLine("You must grow up.");
        }
        */

        /*
        Console.WriteLine("What day is it today?");
        String day = Console.ReadLine();

        switch(day)
        {
        case "Monday":
            Console.WriteLine("Today is Monday!");
            break;
        case "Tuesday":
            Console.WriteLine("Today is Tuesday!");
            break;
        case "Wednesday":
            Console.WriteLine("Today is Wednesday!");
            break;
        case "Thursday":
            Console.WriteLine("Today is Thursday!");
            break;
        case "Friday":
            Console.WriteLine("Today is Friday!");
            break;
        case "Saturday":
            Console.WriteLine("Today is Saturday!");
            break;
        case "Sunday":
            Console.WriteLine("Today is Sunday!");
            break;
        }
        */
        // && is AND(all conditions must be true) ||(only one has to be true)

        /*
        Console.WriteLine("What is the temperature outside: (C)?");
        double temperature = Convert.ToDouble(Console.ReadLine());

        if(temperature>=10 && temperature<=25)
        {
            Console.WriteLine("It is ok outside.");
        }
        else if (temperature <=-50 || temperature>=50)
        {
            Console.WriteLine("Stay home,stay safe.");
        }
        */
    /*    int y = 0;
        for (int i=0; i<10;i++)
        {
            Console.WriteLine("i value is: " +i);
        }
       while (y<20)
        {
            Console.WriteLine("y="+y);
            y++;
        }
    */
        Console.WriteLine("How many rows are there? ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many columns are there? ");
        int columns = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is our symbol ");
        String symbol = Console.ReadLine();
        // nested loop
        for (int i=0; i<rows;i++)
        {
            for (int j=0; j<columns;j++)
            {
            Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}