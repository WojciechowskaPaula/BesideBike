using BesideBike.Domain.Interface;
using BesideBike.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesideBike.Infrastructure.Repositories
{
    public class BikeRepository :IBikeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public BikeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Bike> GetAllBikes()
        {
            return _dbContext.Bikes.ToList();
        }
    }
}
