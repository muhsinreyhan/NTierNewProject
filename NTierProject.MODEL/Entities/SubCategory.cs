﻿using NTierProject.CORE.Entity;
using System;
using System.Collections.Generic;

namespace NTierProject.MODEL.Entities
{
    public class SubCategory:CoreEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }

        public Guid CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Product> Products { get; set; }

    }
}