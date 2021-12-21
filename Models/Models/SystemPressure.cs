using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class SystemPressure
    {
        public int SystemPressureID { get; set; }

        public int SSystemID { get; set; }
        public SSystem SSystem { get; set; }

        public int CoolerPressure { get; set; }
        public int CondenserPressure { get; set; }
        public int LiquidLinePressure { get; set; }


    }
}
