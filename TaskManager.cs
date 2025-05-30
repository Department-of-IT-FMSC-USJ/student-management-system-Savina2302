using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class TaskManager
    {
        LinkedList<Task> toDoTasks = new LinkedList<Task>();
        Stack<Task> inProgressTasks = new Stack<Task>();
        Queue<Task> completedTasks = new Queue<Task>();

        public void AddToDoTask(Task task)
        {
            if (toDoTasks.Count == 0)
            {
                toDoTasks.AddFirst(task);
            }
            else
            {
                var current = toDoTasks.First;
                while (current != null && current.Value.Date <= task.Date)
                {
                    current = current.Next;
                }

                if (current == null)
                    toDoTasks.AddLast(task);
                else
                    toDoTasks.AddBefore(current, task);
            }
        }

       
        public void MoveToInProgress(int taskId)
        {
            var node = toDoTasks.First;
            while (node != null)
            {
                if (node.Value.Id == taskId)
                {
                    node.Value.Status = "In Progress";
                    inProgressTasks.Push(node.Value);
                    toDoTasks.Remove(node);
                    break;
                }
                node = node.Next;
            }
        }

        
        public void CompleteTask()
        {
            if (inProgressTasks.Count > 0)
            {
                Task task = inProgressTasks.Pop();
                task.Status = "Completed";
                completedTasks.Enqueue(task);
            }
            else
            {
                Console.WriteLine("No tasks in progress to complete.");
            }
        }

       
        public void DisplayTasks()
        {
            Console.WriteLine("\nTo Do Tasks:");
            foreach (var task in toDoTasks) Console.WriteLine(task);

            Console.WriteLine("\nIn Progress Tasks:");
            foreach (var task in inProgressTasks) Console.WriteLine(task);

            Console.WriteLine("\nCompleted Tasks:");
            foreach (var task in completedTasks) Console.WriteLine(task);
        }
    }
}
