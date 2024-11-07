using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stations.API.Data;
using Stations.API.Migrations;
using Stations.API.Repositories;

namespace Stations.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RegionsController : ControllerBase
    {
        private readonly StationsDbContext _context;

        public RegionsController(StationsDbContext dbContext) 
        {
            _context = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = _context.Regions.ToList();
            return Ok(regions);
        }

        [HttpGet]
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
