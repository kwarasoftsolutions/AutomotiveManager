using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveManager
{
    public class SubCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<PartType> PartTypes { get; set; }
    }
}
