using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1S3G4.Models
{
    public class appInfo 
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public string Email { get; set; }

        public string? Phone { get; set; }
    }
}
