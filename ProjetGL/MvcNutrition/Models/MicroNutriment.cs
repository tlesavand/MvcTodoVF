using System;

namespace MvcNutrition.Models
{
    public class Micronutriment
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public bool Completed { get; set; }
        public DateTime Deadline { get; set; }
    }
}