using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public double Unitprice { get; set; }
        public short UnitsInStock { get; set; }
        public int? CategoryID { get; set; }
        //
        public virtual List<OrderAndProduct> OrderAndProducts { get; set; }
        public virtual Category Category { get; set; }
    }
}
