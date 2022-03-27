using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.Entities
{
    public class SocialLink
    {
        public Guid UserUserId { get; set; }
        [Key]
        public string Link { get; set; }
        public User User; 
    }
}
