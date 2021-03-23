using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCD.Models
{
    public class Users
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string fio { get; set; }
        public string phone { get; set; }
        // статус студента в смц id
        public int statusUserId { get; set; }        
        public string group { get; set; }
        // род деятельности id 
        public bool photo { get; set; }
        public bool video { get; set; }
        public bool journalist { get; set; }

    }
}
