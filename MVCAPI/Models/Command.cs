using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace MVCAPI.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string  Howto { get; set; }
        [Required]
        public String Line { get; set; }
        [Required]
        public String Platform { get; set; }
    }
}
