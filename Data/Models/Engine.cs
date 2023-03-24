using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Engine
    {
        public int EngineId { get; set; }

        public int Year { get; set; }

        public string Brand { get; set; }

        public string SerialNumber { get; set; }

        [ForeignKey("EngineType")]
        public int EngineTypeId { get; set; }

        public EngineType EngineType { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }

    }
}
