﻿using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class ShipperMap:BaseMap<Shipper>
    {
        public ShipperMap()
        {
            ToTable("Kargocular");
            Property(x => x.CompanyName).HasColumnName("Şirket Adı");
            Property(x => x.Phone).HasColumnName("Telefon");

        }
    }
}
