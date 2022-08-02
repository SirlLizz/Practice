using System;

namespace Practice_7._4.Models
{
    public class Musician
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Country { get; set; } = string.Empty;
        public string MostFamousWork { get; set; } = string.Empty;
    }
}
