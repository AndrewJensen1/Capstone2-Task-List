using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone_2_Task_List
{
    class Task
    {   //field
        private string _memberName;
        private string _description;
        private string _dueDate;
        private bool _completeOrNot;

        public static List<Task> tasks = new List<Task>
        {
            new Task("Dan", "Make coffee", "09/20/2019", false),
            new Task("Lauren", "Make copies", "08/30/2019", false),
            new Task("Chris", "Write documentation", "09/15/2019", false)
        };
        //property
        public string MemberName
        {
            get
            {
                return _memberName;
            }
            set
            {
                _memberName = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        public string DueDate
        {
            get
            {
                return _dueDate;
            }
            set
            {
                _dueDate = value;
            }
        }
        public bool CompleteOrNot
        {
            get
            {
                return _completeOrNot;
            }
            set
            {
                _completeOrNot = value;
            }
        }
        //contructor
        public Task()
        {

        }
        public Task(string name, string what, string when, bool completed = false)
        {
            _memberName = name;
            _description = what;
            _dueDate = when;
            _completeOrNot = completed;
        }
        //methods
        public static void DisplayMenuTaskManager()
        {
            Console.WriteLine("1. List Tasks");
            Console.WriteLine("2. Add Tasks");
            Console.WriteLine("3. Delete Tasks");
            Console.WriteLine("4. Mark Task Complete");
            Console.WriteLine("5. Quit\n");
        }
        public static void ListTasks()
        {
            int i = 0;
            foreach (Task task in tasks)
            {

                i++;
                Console.WriteLine($"{i}: {task.MemberName}, {task.Description}, {task.DueDate}, {task.CompleteOrNot}");
                Console.WriteLine("==================================================");

            }
            Console.WriteLine();
        }
        //methods for adding
        public static void AddTask()
        {
            Task task = new Task();

            Console.WriteLine("Please enter name");
            task.MemberName = Console.ReadLine();

            Console.WriteLine("Enter task description");
            task.Description = Console.ReadLine();

            Console.WriteLine("Enter Due Date");
            task.DueDate = Console.ReadLine();
            Console.WriteLine();

            task.CompleteOrNot = false;
            tasks.Add(task);
        }
        //methods for deleting
        public static void DeleteTask()
        {
            bool go = true;
            while (go)
            {
                Console.WriteLine("What task would you like to delete?");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    Console.WriteLine();
                    result = result - 1;
                    if (result <= tasks.Count && result >= 0)
                    {
                        Console.WriteLine($"{tasks[result].MemberName} {tasks[result].Description} {tasks[result].DueDate} {tasks[result].CompleteOrNot}");
                        Console.WriteLine("\nAre you sure you want to delete this task? y or n");
                        string deleteInput = Console.ReadLine();

                        if (deleteInput == "y")
                        {
                            Console.WriteLine();
                            tasks.RemoveAt(result);
                            go = false;
                        }
                        else if (deleteInput == "n")
                        {
                            Console.WriteLine();
                            go = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid input please try again.");
                }
            }
        }
        //methods for completing 

        public static void MarkTaskComplete()
        {
            bool go = true;
            while (go)
            {
                Console.WriteLine("What task would you like to mark complete?");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    Console.WriteLine();
                    result = result - 1;
                    if (result <= tasks.Count && result >= 0)
                    {
                        Console.WriteLine($"{tasks[result].MemberName}, {tasks[result].Description}, {tasks[result].DueDate}, {tasks[result].CompleteOrNot}");
                        Console.WriteLine("\nAre you sure you want to mark this task complete? y or n");
                        string completeInput = Console.ReadLine();

                        if (completeInput == "y")
                        {
                            tasks[result].CompleteOrNot = true;
                            go = false;
                        }
                        else if (completeInput == "n")
                        {
                            go = false;
                        }
                    }
                }
            }
        }
        public static bool Quit()
        {
            return false;
        }
    }

}
