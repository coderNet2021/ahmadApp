using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string ToWhere   { get; set; }
    }
}
