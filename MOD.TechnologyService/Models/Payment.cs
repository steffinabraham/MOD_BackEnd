
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TechnologyService.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public long PaymentId { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }
        [ForeignKey("Mentor")]
        public long MentorId { get; set; }

        public double Amount { get; set; }

        public double MentorAmount { get; set; }
         public User User { get; set; }
        public Mentor Mentor { get; set; }
    }
}
