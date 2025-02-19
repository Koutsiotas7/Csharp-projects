namespace MyFirstprogram
{
class Human
{
    private string name;
    private int age;
    //Constructor
    public Human(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Eat()
    {
        Console.WriteLine(name+ " is eating.");
    } 
    public void Sleep()
    {
        Console.WriteLine(name+ " is sleeping.");
    } 
}
}