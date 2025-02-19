using System;
using System.Collections.Generic; // For lists

namespace MyFirstProgram
{
class Program
 {
static void Main(string[] args)
    {
        Rabbit rabbit = new Rabbit();
        Hawk hawk = new Hawk();
        Fish fish = new Fish();

        rabbit.Flee();
        hawk.Hunt();
        fish.Flee();
        fish.Hunt();

        List<String> food = new List<String>();
        food.Add("Pizza");
        food.Add("Hamburger");
        food.Add("Hot Dog");
        food.Add("Fries");

        foreach(String item in food)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(food[1]); 
        //List methods:Add,Remove,Insert(index,item),Count,IndexOf(item),
        // LastIndexOf(item),Contains(item),Sort,Reverse,Clear
        String[] foodArray = food.ToArray();
        foreach(String item in foodArray)
        {
            Console.WriteLine(item);
        }
    }
 }
 interface IPrey
 {
    void Flee();
 }
 interface IPredator
 {
    void Hunt();
 }
class Rabbit :IPrey
{
    public void Flee()
    {
        Console.WriteLine("The rabbit runs away.");
    }
}
class Hawk : IPredator
{
    public void Hunt()
    {
        Console.WriteLine("The hawk is searching for food.");
    }
}
class Fish : IPrey, IPredator
{
    public void Flee()
    {
        Console.WriteLine("The fish swims away.");
    }
    public void Hunt()
    {
        Console.WriteLine("The fish is searching for smaller fish.");
    }
}
}