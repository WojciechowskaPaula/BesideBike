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

        public Bike GetBikeById(int id)
        {
            return  _dbContext.Bikes.FirstOrDefault(b => b.Id == id);
           
        }
        public void UpdateBike(Bike bike)
        {
            _dbContext.Bikes.Attach(bike);
            _dbContext.Entry(bike).Property("Name").IsModified = true;
            _dbContext.Entry(bike).Property("PricePerHour").IsModified = true;
            _dbContext.Entry(bike).Property("BikeTypeId").IsModified=true;
            _dbContext.SaveChanges();
        }
    }
}
