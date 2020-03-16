using System;

namespace Configuration.Database
{
    public class Assembly
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Enviroment? Type { get; set; }
    }
}
