using System;

namespace PasswordGeneratorApp.Models
{
    public class GeoName
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
