using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    [Table("Status")]
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        [MaxLength(50)]
        public string StatusType { get; set; }

    }
}
