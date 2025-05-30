namespace CivicMap.Domain.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PostalPrefix { get; set; } // e.g., M4X
        public List<Policy> Policies { get; set; }
    }
}
