using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Task
    {
        private string taskName;
        private int id;
        private string description;
        private DateTime date;
        private string status;

        public string TaskName { get => taskName; set => taskName = value; }
        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Status { get => status; set => status = value; }

        public Task(string taskName, int id, string description, DateTime date)
        {
            TaskName = taskName;
            Id = id;
            Description = description;
            Date = date;
            Status = "To Do";
        }

        public override string? ToString()
        {
            return $"Task Name: {TaskName}, ID: {Id}, Description: {Description}, Date: {Date}, Status: {Status}";
        }
    }
}
