﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesideBike.Domain.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int BikeId { get; set; } 
        public Bike Bike { get; set; }
    }
}
