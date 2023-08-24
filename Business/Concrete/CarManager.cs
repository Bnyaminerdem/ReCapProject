using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
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
