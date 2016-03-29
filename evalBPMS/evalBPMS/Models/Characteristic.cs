using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evalBPMS.Models
{
    public class Characteristic
    {
        public Guid CharacteristicID { get; set; }
        public string Value { get; set; }
        public virtual Category Category { get; set; }


    }
}
