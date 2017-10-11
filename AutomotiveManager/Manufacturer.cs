using System;
using System.Collections.Generic;

namespace AutomotiveManager
{
    public class Manufacturer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Model> Models { get; set; }


        public Manufacturer()
        {
            Models = new HashSet<Model>();
        }
    }
}
