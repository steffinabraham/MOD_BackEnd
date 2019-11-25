using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public long UserId { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(20)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        
        public bool Active { get; set; }
        public IEnumerable<Training> Training { get; set; }
        public IEnumerable<Payment> Payment { get; set; }
    }
}
