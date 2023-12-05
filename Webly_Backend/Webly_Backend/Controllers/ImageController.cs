using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webly_Backend.Models.Database;
using Webly_Backend.Models.Entities;

namespace Webly_Backend.Controllers
{
    [Route("api/image")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        
        public ImageController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
         
        }

        [HttpGet]
        public async Task<IActionResult> GetImages( )
        {
            return Ok(await dbContext.Images.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddImage(AddImageRequest addImageRequest)
        {
            var image = new Image()
            {
                Id = Guid.NewGuid(),
                Url = addImageRequest.Url,
                PostingDate = addImageRequest.PostingDate,
                Tags = addImageRequest.Tags
            };
            await dbContext.Images.AddAsync(image);
            await dbContext.SaveChangesAsync();

            return Ok(image);

        }
    }
}
