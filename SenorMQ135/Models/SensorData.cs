using System;

namespace SenorMQ135.Models
{
    public class SensorData
    {
        public int Id { get; set; }
        public decimal Value { get; set; } 
        public DateTime Timestamp { get; set; }
    }
}
