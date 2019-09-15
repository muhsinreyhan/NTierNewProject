using NTierProject.CORE.Map;
using NTierProject.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierProject.MODEL.Map
{
    public class AppUserMap : CoreMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("dbo.Users");
            Property(x => x.Address).IsOptional();
            Property(x => x.BirthDate).IsOptional(); //.HasColumnType("datetime2")
            Property(x => x.EMail).HasMaxLength(50).IsOptional();
            Property(x => x.UserName).HasMaxLength(50).IsRequired();
            Property(x => x.PhoneNumber).IsOptional();
            Property(x => x.UserRole).IsOptional();
            Property(x => x.Name).HasMaxLength(50).IsRequired();
            Property(x => x.SurName).HasMaxLength(50).IsRequired();
            Property(x => x.ImagePath).HasMaxLength(50).IsOptional();

        }
    }
}
