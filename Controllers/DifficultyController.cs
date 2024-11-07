using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stations.API.Data;

namespace Stations.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DifficultyController : ControllerBase
    {
        private readonly StationsDbContext _context;

        public DifficultyController(StationsDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpGet]
        [Authorize(Roles = "Writer")]
        public IActionResult GetAll()
        {
            var difficulties = _context.Difficulties.ToList();
            return Ok(difficulties);
        }

        [HttpGet]
        [Route("{id:guid}")]
        [Authorize(Roles = "Reader")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var difficulty = _context.Difficulties.Find(id);
            if (difficulty == null)
                return NotFound();

            return Ok(difficulty);
        }
    }
}
