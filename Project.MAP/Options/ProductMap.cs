using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class ProductMap:BaseMap<Product>
    {
        public ProductMap()
        {
            Property(x => x.ProductName).HasColumnName("urun Adı");
            Property(x => x.Unitprice).HasColumnName("Urun fiyatı");
            Property(x => x.UnitsInStock).HasColumnName("urun Stok Sayısı");
            ToTable("Urunler");
        }
    }
}
