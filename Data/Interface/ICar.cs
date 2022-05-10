using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface ICar
    {
        List<Car> GetCars(string color);
        Car Post(int id, bool acikKapali);
        bool Delete(int id);
    }
}
