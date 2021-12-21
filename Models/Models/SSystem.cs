using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
   public  class SSystem
    {
        public int SSystemID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        //[DataType(DataType.Currency)]
        //[Column(TypeName = "money")]
        //public decimal Budget { get; set; }

        [DataType(DataType.Time)]
       
        [Display(Name = "Running Time")]
        public DateTime RunningTime { get; set; }

       public SystemPressure SystemPressure { get; set; }


    }
}
