using ReCapProject.Business.Abstract;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.Business.Concrete
{
    internal class CarManager : ICarService
    {
        private ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAllCars() => _carDal.GetAll();

        public Car GetCarById(int id) => _carDal.GetById(id);

        public void AddCar(Car car) => _carDal.Add(car);

        public void UpdateCar(Car car) => _carDal.Update(car);

        public void DeleteCar(int id) => _carDal.Delete(id);
    }
}
