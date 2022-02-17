using BesideBike.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesideBike.Domain.Interface
{
    public interface IBikeRepository
    {
        IEnumerable<Bike> GetAllBikes();
    }
}
