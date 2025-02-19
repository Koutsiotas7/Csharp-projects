using System;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();

        Console.WriteLine("Car Speed: " + car.speed);
        Console.WriteLine("Car Wheels: " + car.wheels);
        car.go(); // ✅ Prints "Car is moving."
        Console.WriteLine("Car's new Speed: " + car.speed);

        Console.WriteLine("Bicycle Speed: " + bicycle.speed);
        Console.WriteLine("Bicycle Wheels: " + bicycle.wheels);
        bicycle.go(); // ✅ Prints "Bicycle is moving."

        Console.WriteLine("Boat Speed: " + boat.speed);
        Console.WriteLine("Boat Wheels: " + boat.wheels);
        boat.go(); // ✅ Prints "Boat is moving."
    }
}

// ✅ Abstract class (cannot be instantiated directly)
abstract class Vehicle
{
    public int speed = 0;
    public int wheels;
    public string name;

    public Vehicle(string name, int wheels) // ✅ Constructor to set name and wheels
    {
        this.name = name;
        this.wheels = wheels;
    }

    public abstract void go(); // ✅ Abstract method (must be overridden)
}

// ✅ Car class overrides go()
class Car : Vehicle
{
    public Car() : base("Car", 4) { }

    public override void go()
    {
        speed = 120;
        Console.WriteLine(name + " is moving.");
    }
}

// ✅ Bicycle class overrides go()
class Bicycle : Vehicle
{
    public Bicycle() : base("Bicycle", 2) { }

    public override void go()
    {
        speed = 50;
        Console.WriteLine(name + " is moving.");
    }
}

// ✅ Boat class overrides go()
class Boat : Vehicle
{
    public Boat() : base("Boat", 0) { }

    public override void go()
    {
        speed = 90;
        Console.WriteLine(name + " is moving.");
    }
}
