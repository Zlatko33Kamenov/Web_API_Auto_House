using System.ComponentModel.DataAnnotations;

namespace Auto_House.Models
{
    public class Car
    {
        [Key]
        public uint Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public uint Price { get; set; }
        public DateTime DateOfManifacture { get; set; }
        public string Color { get; set; }
    }
}
