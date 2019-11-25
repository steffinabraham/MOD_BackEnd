using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Models
{
    [Table("Technology")]
    public class Technology
    {
        [Key]
        public long SkillId { get; set; }
        [StringLength(20)]
        public string SkillName { get; set; }

        [StringLength(20)]
        public string TOC { get; set; }


        public double Fee { get; set; }

        public int Duration { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
    }
}
