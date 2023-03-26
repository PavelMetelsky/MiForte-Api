using System.ComponentModel.DataAnnotations;

namespace Piano.Entities
{
    public class SocialLink
    {
        [Key]
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Link { get; set; }
    }
}
