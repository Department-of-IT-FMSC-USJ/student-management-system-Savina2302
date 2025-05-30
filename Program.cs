using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        public static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== TO-DO LIST MANAGEMENT MENU =====");
                Console.WriteLine("1. Add New Task");
                Console.WriteLine("2. Move Task to In Progress");
                Console.WriteLine("3. Complete Task");
                Console.WriteLine("4. Display All Tasks");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Task Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Task ID (integer): ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Task Description: ");
                        string description = Console.ReadLine();

                        Console.Write("Task Date (yyyy-MM-dd): ");
                        string dateInput = Console.ReadLine();
                        DateTime date = DateTime.ParseExact(dateInput, "yyyy-MM-dd", null);

                        Task task = new Task(name, id, description, date);
                        manager.AddToDoTask(task);
                        Console.WriteLine("Task added successfully.");
                        break;

                    case "2":
                        Console.Write("Enter Task ID to move to In Progress: ");
                        int inProgressId = int.Parse(Console.ReadLine());
                        manager.MoveToInProgress(inProgressId);
                        break;

                    case "3":
                        manager.CompleteTask();
                        break;

                    case "4":
                        manager.DisplayTasks();
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
        }
    }      
    
    
    
}
