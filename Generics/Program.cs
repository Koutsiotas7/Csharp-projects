using System;

namespace MyFirstProgram
{
class Program
    {
    static void Main(String[] args)
        {
            int[] intArray = {1,2,3};
            double[] doubleArray = {1.0,2.0,3.0};
            String[] stringArray = {"1", "2", "3"};

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);
        }
    
    
    public static void displayElements<Thing>(Thing[] array)
        {
            foreach(Thing item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}