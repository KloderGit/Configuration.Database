using System;
using System.Collections.Generic;

namespace Configuration.Database
{
    public class Assembly
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Enviroment? Type { get; set; }

        public IEnumerable<Param> Params { get; set; }
    }
}
