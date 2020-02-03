using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
   public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime? CreatedTime  { get; set; }
    public DateTime? UpdatedTime{ get; set; }
        public DateTime? DeletedTime { get; set; }

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DataStatus Status { get; set; }

        public BaseEntity()
        {
            CreatedTime = DateTime.Now;
            Status = DataStatus.Inserted;
        }



    }
}
