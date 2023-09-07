using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            //_cars = new List<Car>
            //{
            //    new Car {CarId =1, BrandId = 2, ColorId =3, ModelYear = 2023, DailyPrice = 500,Description = " : Sports Car" },
            //    new Car {CarId =4, BrandId = 5, ColorId = 6, ModelYear = 2022, DailyPrice = 700,Description = " : Luxury Car" },
            //    new Car {CarId =7, BrandId = 8, ColorId = 9, ModelYear = 2019, DailyPrice = 250,Description = " : Economic Car" },
            //};
        }
        public List<Car> GetAll() { return _cars; }
        public Car GetById(int id)
        {
            Car car = _cars.FirstOrDefault(c => c.CarId == id);
            return car;
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(c => c.CarId == car.CarId);
            if (carToUpdate != null)
            {
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.ModelYear = car.ModelYear;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;
            }
        }
        public void Delete(int id)
        {
            Car carToDelete = _cars.FirstOrDefault(c => c.CarId == id);
            if (carToDelete != null)
            {
                _cars.Remove(carToDelete);
            }
        }

        public List<Car> GetAllCars(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}

