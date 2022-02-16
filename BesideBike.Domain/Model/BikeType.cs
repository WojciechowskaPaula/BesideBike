using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesideBike.Domain.Model
{
    public class BikeType
    {
        public int BikeTypeId { get; set; }
        public string Name { get; set; }
        public ICollection<Bike> Bikes { get; set; }
    }
}
