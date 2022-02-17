using BesideBike.Application.Viewmodels;
using BesideBike.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesideBike.Application.Interfaces
{
    public interface IBikeService
    {
        IEnumerable<BikesVM> GetAllBikes();
    }
}
