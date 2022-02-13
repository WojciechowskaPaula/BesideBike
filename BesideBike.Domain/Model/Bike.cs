﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesideBike.Domain.Model
{
    public class Bike
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int PricePerHour { get; set; }
        public BikeType BikeType { get; set; }
        public Order Order { get; set; }
    }
}
