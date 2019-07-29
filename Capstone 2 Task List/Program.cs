using System;
using System.Collections.Generic;

namespace Capstone_2_Task_List
{
    class Program
    {
        static void Main(string[] args)
        {   bool go =true;
            while (go)
            {
                Console.WriteLine("Welcome to the Task Manager please see options below:\n");
                Task.DisplayMenuTaskManager();
                Task task = new Task();

                Console.WriteLine("What would you like to do?");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    Console.WriteLine();
                    if (result == 1)
                    {
                        Task.ListTasks();
                    }
                    else if (result == 2)
                    {
                        Task.AddTask();
                    }
                    else if (result == 3)
                    {
                        Task.ListTasks();
                        Task.DeleteTask();
                    }
                    else if (result == 4)
                    {
                        Task.ListTasks();
                        Task.MarkTaskComplete();
                    }
                    else if (result == 5)
                    {
                        Console.WriteLine("Good Bye");
                        //Console.WriteLine("Press any key to exit. . .");
                        //Console.ReadKey();
                        //System.Environment.Exit(0);
                        go = Task.Quit();
                        
                    }
                   
                }
                else
                {
                    Console.WriteLine("\nI'm sorry that is not a valid input please try agian.\n");
                }
            }
        }
    }
}
