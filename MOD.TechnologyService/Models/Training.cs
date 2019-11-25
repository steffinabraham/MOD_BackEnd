using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TechnologyService.Models
{
    [Table("Training")]
    public class Training
    {
        [Key]
        public long TrainingId { get; set; }
        [ForeignKey("User")]

        public long UserId { get; set; }
        [ForeignKey("Mentor")]
        public long MentorId { get; set; }
        [ForeignKey("Technology")]

        public long SkillId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [StringLength(20)]
        public string TimeSlot { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        public long Progress { get; set; }

        public int Rating { get; set; }

        public User User { get; set; }
        public Mentor Mentor{ get; set; }
        public Technology Technology { get; set; }




    }
}
