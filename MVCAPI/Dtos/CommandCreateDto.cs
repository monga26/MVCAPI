using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPI.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string Howto { get; set; }
        [Required]
        public String Line { get; set; }
        [Required]
        public String Platform { get; set; }
    }
}
