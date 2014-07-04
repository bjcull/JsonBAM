using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonBAM.Models
{
    public class LogItemVM
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string LogJson { get; set; }
        public DateTime DateCreated { get; set; }
    }
}