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
        [Key]
        public string UserUserId { get; set; }
        
        public string Link { get; set; }
        public User User; 
    }
}
