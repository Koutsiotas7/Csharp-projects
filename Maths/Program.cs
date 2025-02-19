using System;

class Program
{
    static void Main(string[] args)
    {
        // + - * / % 
 /*    int apples = 4;
       double napples = Math.Sqrt(apples); // Math.Pow(apples, 2 );
     //Console.WriteLine(napples);

       Random random = new Random();
       int num = random.Next(1, 10);
       Console.WriteLine(num); */

       String fullName = "Bro";
       String phone = "690-123-4567";
       fullName.ToUpper();
       phone = phone.Replace("-", "");

       Console.WriteLine(fullName);
       Console.WriteLine(fullName.Length);
       Console.WriteLine(phone);
    }
}