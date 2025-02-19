using System;
using System.Collections.Generic; // For lists

namespace MyFirstProgram
{
class Program
    {
static void Main(string[] args)
        {   
            Car car = new Car("Porsche");
            Console.WriteLine(car.Model);
        }
    }
}

class Car
{
    public String Model {get; set;}
    public Car(String model)
    {
        this.Model = model;
    }
}