using ReCapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.Business.Abstract
{
    internal interface ICarService
    {
        List<Car> GetAllCars();
        Car GetCarById(int id);
        void AddCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int id);
    }
}
