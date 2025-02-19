using System;

namespace MyFirstprogram
{
class Program
    {
        static void Main(String[] args)
        {
        /*    Messages.Hello();
            Messages.Waiting();
            Messages.Goodbye();
        */
    /*    Human human1 = new Human("Rick", 62);
        Human human2 = new Human("Nick", 26);

        human1.Eat();
        human1.Sleep();

        human2.Eat();
        human2.Sleep(); */

        Car car1 = new Car("Mustang");
        Car car2 = new Car("Corvette");
        Car car3 = new Car("Lambo");

        Console.WriteLine(Car.numberOfCars);
        Car.StartRace();
        }
    }
    class Car 
    {
        String model;
        public static int numberOfCars;
        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }
        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}
