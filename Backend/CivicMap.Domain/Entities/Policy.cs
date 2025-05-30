namespace CivicMap.Domain.Entities
{
    public class Policy
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Summary { get; set; }
        public List<string> ImpactedAreas { get; set; } = new();
        public required string Category { get; set; }
        public DateTime EffectiveDate { get; set; }
        public List<string> ReferenceUrl { get; set; } = new();
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
