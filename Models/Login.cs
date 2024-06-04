using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    [Table("Login")]
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        public string Username { get; set; }
        [MaxLength(10)]
        public string PasswordHash { get; set; }

    }
}
