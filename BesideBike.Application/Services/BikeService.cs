using BesideBike.Application.Interfaces;
using BesideBike.Application.Viewmodels;
using BesideBike.Domain.Interface;
using BesideBike.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesideBike.Application.Services
{
    public class BikeService : IBikeService
    {
        private readonly IBikeRepository _bikeRepository;

        public BikeService(IBikeRepository bikeRepository)
        {
            _bikeRepository = bikeRepository;
        }

        public IEnumerable<BikesVM> GetAllBikes()
        {
            var bikes = _bikeRepository.GetAllBikes();
            var VmList = new List<BikesVM>();
            foreach (var bike in bikes)
            {
                var vm = new BikesVM();
                vm.Name = bike.Name;
                vm.Id = bike.Id;
                vm.BikeTypeId = bike.BikeTypeId;
                vm.PricePerHour = bike.PricePerHour;
                VmList.Add(vm);
            }
           return VmList;

        }

    }
}
