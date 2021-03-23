using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMCD.Models;

namespace SMCD.Data.ViewModel
{
    public class TechniqueListModel
    {
        public IEnumerable<Technique> Technique { get; set; }
    }
}
