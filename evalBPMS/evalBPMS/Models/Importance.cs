﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evalBPMS.Models
{
    public class Importance
    {
        public Guid ImportanceID { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public virtual ICollection<Evaluation> Evaluation { get; set; }
    }
}
