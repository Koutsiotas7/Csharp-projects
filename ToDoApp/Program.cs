using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>(); // 🔹 Global task list

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("To-Do List App");
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Mark Task as Done");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1": ViewTasks(); break;
                case "2": AddTask(); break;
                case "3": CompleteTask(); break;
                case "4": return;
                default: Console.WriteLine("Invalid option. Press Enter to try again."); Console.ReadLine(); break;
            }
        }
    }

    static void ViewTasks()
    {
        Console.Clear();
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
        }
        else
        {
            Console.WriteLine("Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
        Console.WriteLine("\nPress Enter to go back.");
        Console.ReadLine();
    }

    static void AddTask()
    {
        Console.Clear();
        Console.Write("Enter a new task: ");
        string task = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(task))
        {
            tasks.Add(task);
            Console.WriteLine("Task added! Press Enter to continue.");
        }
        else
        {
            Console.WriteLine("Task cannot be empty. Press Enter to try again.");
        }
        Console.ReadLine();
    }

    static void CompleteTask()
    {
        Console.Clear();
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
            Console.WriteLine("\nPress Enter to go back.");
            Console.ReadLine();
            return;
        }

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }

        Console.Write("Enter the number of the task to mark as done: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            tasks.RemoveAt(taskNumber - 1);
            Console.WriteLine("Task marked as done! Press Enter to continue.");
        }
        else
        {
            Console.WriteLine("Invalid number! Press Enter to try again.");
        }
        Console.ReadLine();
    }
}
