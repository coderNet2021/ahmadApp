using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Project
    {
        public int ProjectID { get; set; }

        [StringLength(80, MinimumLength = 3)]
        public string Name { get; set; }

        public ICollection<Chiller> Chillers { get; set; }
    }
}
