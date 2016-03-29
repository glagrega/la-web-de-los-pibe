using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evalBPMS.Models
{
    public class Evaluation
    {
        public Guid EvaluationID { get; set; }
        public int Value { get; set; }
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual Importance Importance { get; set; }
        public virtual Tool Tool { get; set; }

    }
}
