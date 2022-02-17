using BesideBike.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesideBike.Application.Viewmodels
{
    public class BikesVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PricePerHour { get; set; }
        public int BikeTypeId { get; set; }
        
        
    }
}
