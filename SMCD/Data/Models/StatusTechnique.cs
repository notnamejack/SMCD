using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCD.Models
{
    public class StatusTechnique
    {
        public int Id { get; set; }
        public string status { get; set; }

        public List<Technique> Technique { get; set; }

        public StatusTechnique()
        {
            Technique = new List<Technique>();
        }
    }
}
