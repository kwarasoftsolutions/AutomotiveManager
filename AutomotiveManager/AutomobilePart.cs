using System;
using System.Collections.Generic;

namespace AutomotiveManager
{
    public class AutomobilePart
    {
        public Guid Id { get; set; }
        public string PartName { get; set; }
        public string PartDescription { get; set; }
        
        public Guid PartTypeId { get; set; }
        public PartType PartType { get; set; }

        public Guid ModelId { get; set; }
        public virtual Model Automobile { get; set; }

        public ICollection<PartPrice> Prices { get; set; }


        public AutomobilePart()
        {
            Prices = new HashSet<PartPrice>();
        }

    }
}
