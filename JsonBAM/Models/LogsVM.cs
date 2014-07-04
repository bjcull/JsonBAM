using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonBAM.Models
{
    public class LogsVM
    {
        public string Key { get; set; }
        public IEnumerable<LogItemVM> Logs { get; set; }
    }
}