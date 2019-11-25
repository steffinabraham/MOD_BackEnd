using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Models
{
    [Table("Mentor")]
    public class Mentor
    {
        [Key]
        public long MentorId { get; set; }

        [StringLength(20)]
        public string MentorName { get; set; }

        public string Email { get; set; }

        public double MobileNo { get; set; }

        public int Experience { get; set; }

        public string MentorSkills { get; set; }
        public string TimeSlot { get; set; }

        public bool Availability { get; set; }
        public bool Active { get; set; }
     
        public string Password { get; set; }

        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> Payments { get; set; }
    }
}