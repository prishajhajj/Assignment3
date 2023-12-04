namespace Webly_Backend.Models.Entities
{
    public class Image
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public User User { get; set; }
        public DateTime PostingDate { get; set; }
        public List<Tag> Tags { get; set; }
 

    }
}
