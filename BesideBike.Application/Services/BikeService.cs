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

        public BikesVM GetBikeForEdit(int id)
        {
            var bike =_bikeRepository.GetBikeById(id);
            var vm = new BikesVM();
            vm.Id =bike.Id;
            vm.Name=bike.Name;
            vm.BikeTypeId=bike.BikeTypeId;
            vm.PricePerHour=bike.PricePerHour;
            return vm;
        }

        public Bike Update(BikesVM bikeVm)
        {
            var updatedBike = new Bike();
            updatedBike.Id = bikeVm.Id;
            updatedBike.Name = bikeVm.Name;
            updatedBike.PricePerHour= bikeVm.PricePerHour;
            updatedBike.BikeTypeId= bikeVm.BikeTypeId;
            _bikeRepository.UpdateBike(updatedBike);
            return updatedBike;
        }

    }
}
