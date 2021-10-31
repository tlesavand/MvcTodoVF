using System;

namespace MvcTodo.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool Completed { get; set; }
        public DateTime Deadline { get; set; }
    }
}