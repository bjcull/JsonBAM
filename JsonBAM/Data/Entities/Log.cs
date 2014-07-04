using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonBAM.Data.Entities
{
    public class Log
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string HeaderJson { get; set; }
        public string LogJson { get; set; }
        public DateTime DateCreated { get; set; }
        public string Verb { get; set; }
    }
}