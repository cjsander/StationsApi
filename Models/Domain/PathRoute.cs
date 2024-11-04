namespace Stations.API.Models.Domain
{
    public class PathRoute
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public double LengthInKm { get; set; }
        public string? StationImageUrl { get; set; }

        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }

        //Navigation properties
        public required Difficulty Difficulty { get; set; }
        public required Region Region { get; set; }
    }
}
