using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stations.API.Data;

namespace Stations.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RegionsController : ControllerBase
    {
        private readonly StationsDbContext _context;

        public RegionsController(StationsDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpGet]
        [Authorize(Roles = "Writer")]
        public IActionResult GetAll()
        {
            var regions = _context.Regions.ToList();
            return Ok(regions);
        }

        [HttpGet]
        [Authorize(Roles = "Reader")]
        [Route("{id:guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var region = _context.Regions.Find(id);
            if (region == null)
                return NotFound();

            return Ok(region);
        }
    }
}
