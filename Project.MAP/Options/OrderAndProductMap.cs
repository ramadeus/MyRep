using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class OrderAndProductMap:BaseMap<OrderAndProduct>
    {

        public OrderAndProductMap()
        {
            ToTable("Siparişler");
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            });
        }
    }
}
