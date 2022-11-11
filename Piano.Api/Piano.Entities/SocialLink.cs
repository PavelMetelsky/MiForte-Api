using System.ComponentModel.DataAnnotations;

namespace Piano.Entities
{
    public class SocialLink
    {
        public Guid UserId { get; set; }
        public string Link { get; set; }
        [Key]
        public int Id { get; set; }
    }
}
