using System;

namespace AutomotiveManager
{
    public class PartPrice
    {
        public Guid Id { get; set; }
        public decimal Price { get; set;}
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsActive { get; set; }

        public Guid AutomobilePartId { get; set; }
        public virtual AutomobilePart Part { get; set; }

    }
}
