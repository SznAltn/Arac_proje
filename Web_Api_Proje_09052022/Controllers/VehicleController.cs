using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Interface;
using Data.Repository;
using Data.Model;
using System.Net.Http;
using System.Net;

namespace Web_Api_Proje_09052022.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> _logger;

        private readonly ICar cars = new VehicleRepository();
        private readonly IBoat boats = new VehicleRepository();
        private readonly IBus buses = new VehicleRepository();

        public VehicleController(ILogger<VehicleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("boats")]
        public IEnumerable<Boat> GetBoats(string color)
        {
            return boats.GetBoats(color);
        }
        [HttpGet]
        [Route("buses")]
        public IEnumerable<Bus> GetBuses(string color)
        {
            return buses.GetBuses(color);
        }
        [HttpGet]
        [Route("cars")]
        public IEnumerable<Car> GetCars(string color)
        {
            return cars.GetCars(color);
        }

        [HttpPost]
        [Route("cars")]
        public Car Post(int id, bool acikKapali)
        {
            return cars.Post(id, acikKapali);
        }

        [HttpDelete]
        [Route("cars")]
        public bool Delete(int id)
        {
            return cars.Delete(id);
        }
    }
}
