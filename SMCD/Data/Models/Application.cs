using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCD.Models
{
    public class Application
    {
        public int id { get; set; }
        // id меровриятия 
        public int event_id { get; set; }
        // id студента 
        public int user_is { get; set; }
        public int role_id { get; set; }
        public string linkMaterial { get; set; }
        public int points { get; set; }
    }
}
