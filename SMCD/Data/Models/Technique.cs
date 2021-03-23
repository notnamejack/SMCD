using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCD.Models
{
    public class Technique
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public string technicalCondition { get; set; }
        // id техники
        //public int? StatusTechniqueId { get; set; }
        public StatusTechnique StatusTechnique { get; set; }
    }
}
