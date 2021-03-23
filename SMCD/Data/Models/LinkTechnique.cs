using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCD.Models
{
    public class LinkTechnique
    {
        public int id { get; set; }
        // id мероприятия 
        public int Application_id { get; set; }
        // id техники
        public int Technique_id { get; set; }
        public string up { get; set; }
        public string after { get; set; }

    }
}
