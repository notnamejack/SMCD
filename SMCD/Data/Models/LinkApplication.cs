using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCD.Models
{
    public class LinkApplication
    {
        public int id { get; set; }
        // id заявки 
        public int application_id { get; set; }
        public int user_id { get; set; }
    }
}
