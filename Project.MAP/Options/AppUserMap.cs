using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class AppUserMap:BaseMap<AppUser>
    {
        public AppUserMap()
        {
            Property(x => x.UserName).HasColumnName("Kullanıcı Adı").IsRequired();
            Property(x => x.Password).HasColumnName("Sifre").IsRequired();
            Property(x => x.Email).HasColumnName("E mail").IsRequired();
            HasOptional(x => x.AppUserDetail).WithRequired(x => x.AppUser);
            ToTable("Kullanıcılar");
        }

    }
}
