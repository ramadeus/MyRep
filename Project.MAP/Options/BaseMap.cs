using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public abstract class BaseMap<T>: EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMap()
        {
            Property(x => x.CreatedTime).HasColumnName("Veri giriş tarihi");
            Property(x => x.UpdatedTime).HasColumnName("Guncelleme Tarihi");
            Property(x => x.DeletedTime).HasColumnName("Silme Tarihi");
            Property(x => x.CreatedBy).HasColumnName("Yaratan Kişi").IsOptional();
            Property(x => x.DeletedBy).HasColumnName("Silen Kişi");
            Property(x => x.UpdatedBy).HasColumnName("Guncelleyen Kişi");
            Property(x => x.Status).HasColumnName("Veri durumu");
        }

    }
}
