using BesideBike.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesideBike.Application.Viewmodels
{
    public class BikesVM
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Price")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid Number")]
        public int PricePerHour { get; set; }
        [Required, DisplayName("Bike Type Id")]
        public int BikeTypeId { get; set; }
        
        
    }
}
