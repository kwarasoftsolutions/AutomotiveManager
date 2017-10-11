﻿using System;

namespace AutomotiveManager
{
    public class PartType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
