using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evalBPMS.Models
{
    public class Tool
    {
        public Guid ToolID { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public virtual ICollection<Evaluation> Evaluation { get; set; }
    }
}
