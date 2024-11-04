using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stations.API.Data;

namespace Stations.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PathRoutesController : ControllerBase
    {
        private readonly StationsDbContext _context;

        public PathRoutesController(StationsDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var paths = _context.PathRouters.ToList();
            return Ok(paths);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var path = _context.PathRouters.Find(id);
            if (path == null)
                return NotFound();

            return Ok(path);
        }
    }
}
