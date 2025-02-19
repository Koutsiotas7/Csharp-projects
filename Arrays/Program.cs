using System;

class Program
{
    static void Main(String[] args)
    {
      //  String[] cars = ["BMW", "Mustang", "Corvette"];

      /*  for (int i=0; i<cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
     */

    /*    foreach (String car in cars)
        {
            Console.WriteLine(car);
        }
    */
//    String name = "Chris";
 //   int age = 27;
 //   singHappyBirthday(name, age);

 /*   double x,y;
    Console.WriteLine("Enter number x: ");
    x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter number y: ");
    y = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("x * y = " + Multiply(x,y)); */
  //  result = Multiply(x,y);

  String[] ford = {"Mustang", "F-150", "Explorer"};
  String[] chevy = {"Corvette", "Camaro", "Silverado"};
  String[] Toyota = {"Corolla", "Camry", "Rav4"};

  String[,] parkingLot = {{"Mustang", "F-150", "Explorer"},
                          {"Corvette", "Camaro", "Silverado"},
                          {"Corolla", "Camry", "Rav4"}
  };

  parkingLot[0, 2] = "Fusion";
  parkingLot[2, 0] = "Tacoma";
 /* foreach(String car in parkingLot)
  {
    Console.WriteLine(car);
  } */
  for (int i=0;i<parkingLot.GetLength(0); i++)
  {
    for (int j=0;j<parkingLot.GetLength(1); j++)
    {
      Console.Write(parkingLot[i,j] + " ");
    }
    Console.WriteLine();
  }
    }
  /*  static void singHappyBirthday(String x, int y)
    {
        Console.WriteLine("Happy Birthday to You.");
        Console.WriteLine("Happy Birthday to You.");
        Console.WriteLine("Happy Birthday dear " +x);
        Console.WriteLine("Happy Birthday to You.");
        Console.WriteLine("You now are " + y + " years old.");
    }
  */
  /*  static double Multiply(double x, double y)
    {
        double z = x * y;
        return z;
    }
  */


}