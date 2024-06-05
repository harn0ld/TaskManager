using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    [Table("Quotes")]
    public class Quotes
    {
        [Key]
        public int QuoteId { get; set; }
        [MaxLength(200)]
        public string Quote { get; set; }
        [MaxLength(50)]
        public string Author { get; set; }

    }
}
