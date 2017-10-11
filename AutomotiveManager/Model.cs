using System;

namespace AutomotiveManager
{
    public class Model
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid ManufacturerId { get; set; }
        public virtual Manufacturer Make { get; set; }

        public Guid ManufactureYearId { get; set; }
        public virtual ManufactureYear Year { get; set; }

        public Guid BodyStyleId { get; set; }
        public virtual BodyStyle BodyStyle { get; set; }

        public Guid EngineSizeId { get; set; }
        public virtual EngineSize EngineSize { get; set; }

        public Guid FuelTypeId { get; set; }
        public virtual FuelType FuelType { get; set; }

        public Guid TransmissionTypeId { get; set; }
        public virtual TransmissionType TransmissionType { get; set; }
    }
}
