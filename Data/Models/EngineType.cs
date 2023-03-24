namespace Data.Models
{
    public class EngineType
    {
        public int EngineTypeId { get; set; }

        public string Model { get; set; }

        public string Name { get; set; }

        public List<Engine> Engines;
    }
}
