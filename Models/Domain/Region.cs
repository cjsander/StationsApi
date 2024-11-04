namespace Stations.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string? GeoCode { get; set; }
        public string? Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
