using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class FastingLog
    {
        public int Id {get; set;}
        
        [Required]
        public DateTime StartTime { get; set; }
    
        [Required]
        public DateTime EndTime { get; set; }
        
        public string? Notes { get; set; }
    }
}