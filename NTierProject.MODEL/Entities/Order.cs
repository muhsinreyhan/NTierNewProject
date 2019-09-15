using NTierProject.CORE.Entity;
using System;
using System.Collections.Generic;

namespace NTierProject.MODEL.Entities
{
    public class Order:CoreEntity
    {
        public Guid AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }
        public bool Confirmed { get; set; }

        //Mapping
        //Lazy Loading sebebiyle Virtual olarak tanımladık.
        public virtual List<OrderDetail> OrderDetails { get; set; }


    }
}