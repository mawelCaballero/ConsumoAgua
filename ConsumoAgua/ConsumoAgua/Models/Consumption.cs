using System;

namespace ConsumoAgua.Models
{
    public class Consumption
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public int CubicLiters { get; set; }
        public string Description { get; set; }
    }
}
