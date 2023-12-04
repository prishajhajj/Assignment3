using Webly_Backend.Models.Database;

namespace Webly_Backend.Data.Services
{
    public class ImageService
    {
        private AppDbContext _context;
        public ImageService(AppDbContext context)
        {
            _context = context;
        }
    }
}
