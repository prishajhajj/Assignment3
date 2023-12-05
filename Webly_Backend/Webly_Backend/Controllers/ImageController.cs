using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webly_Backend.Models.Database;

namespace Webly_Backend.Controllers
{
    [Route("api/image")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        
        public ImageController(AppDbContext dbContext)
        {
                
        }


        [HttpGet]
        public IActionResult GetImages( )
        {
            return Ok(dbContext.Images.ToList());
        }
    }
}
