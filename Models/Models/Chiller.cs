using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Chiller
    {
        public int ChillerID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        public ICollection<SSystem> SSystems { get; set; }
    }
}
