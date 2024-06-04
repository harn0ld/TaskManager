using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    [Table("Priorities")]
    public class Priorities
    {
        [Key]
        public int PriorityId { get; set; }
        [MaxLength(50)]
        public string PriorityType { get; set; }
        [MaxLength(50)]
        public string Reason { get; set; }

        public ICollection<TaskModel> Tasks { get; set; }
    }
}
