using System.ComponentModel.DataAnnotations;

namespace Stations.API.Models.DTO
{
    public class AddRegionRequestDto
    {
        //TODO: Add relevant code
        [Required]
        [MinLength(5, ErrorMessage = "Name has to be a minimum of 5 characters")]
        [MaxLength(100, ErrorMessage = "Name has to be a maximum of 100 characters")]
        public string Name { get; set; }

        public string? GeoCode { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
