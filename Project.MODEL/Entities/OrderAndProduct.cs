using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
   public class OrderAndProduct:BaseEntity
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }


        //RPB
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

    }
}
