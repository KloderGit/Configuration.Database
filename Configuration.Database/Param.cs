using System;
using System.Collections.Generic;
using System.Text;

namespace Configuration.Database
{
    public class Param
    {
        public int Id { get; set; }
        public bool Active { get; set; } = true;
        public int? AssemblyId { get; set; }
        public Assembly Assembly { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
