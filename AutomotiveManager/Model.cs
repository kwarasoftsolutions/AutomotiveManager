using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveManager
{
    public class Model
    {
        public Guid Id { get; set; }
        public string ModelName { get; set; }

        public Guid AutomobileId { get; set; }
        public Guid ManufactureYearId { get; set; }

        public Automobile Automobile { get; set; }
        public ManufactureYear Year { get; set; }
    }
}
