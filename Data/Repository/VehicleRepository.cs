using Data.Interface;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class VehicleRepository : ICar, IBus, IBoat
    {
        List<Car> listCars = new List<Car>
        {
            new Car{Id=1,Color="White", Headlight=false, Wheel=false},
            new Car{Id=2,Color="Red", Headlight=false, Wheel=false},
            new Car{Id=3,Color="Blue", Headlight=false, Wheel=false},
            new Car{Id=4,Color="Black", Headlight=false, Wheel=false}
        };
        List<Boat> listBoats = new List<Boat>
        {
            new Boat{Id=5,Color="White"},
            new Boat{Id=6,Color="Red"},
            new Boat{Id=7,Color="Blue"},
            new Boat{Id=8,Color="Black"}
        };
        List<Bus> listBuses = new List<Bus>
        {
            new Bus{Id=9,Color="White"},
            new Bus{Id=10,Color="Red"},
            new Bus{Id=11,Color="Blue"},
            new Bus{Id=12,Color="Black"}
        };

        public List<Boat> GetBoats(string color)
        {
            return listBoats.Where(x => x.Color == color).ToList();
        }

        public List<Bus> GetBuses(string color)
        {
            return listBuses.Where(x => x.Color == color).ToList();
        }

        public List<Car> GetCars(string color)
        {
            return listCars.Where(x => x.Color == color).ToList();
        }
        public Car Post(int id, bool acikKapali)
        {
            var car = listCars.Where(x => x.Id == id).SingleOrDefault();
            if (car != null)
            {
                car.Headlight = acikKapali;
            }
            return car;
        }

        public bool Delete(int id)
        {
            var car = listCars
                .Where(s => s.Id == id)
                .FirstOrDefault();

            if (car != null)
            {
                listCars.Remove(car);
                return true;
            }
            return false;
        }
    }
}
