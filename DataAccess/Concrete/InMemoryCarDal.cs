using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id =1, BrandId = 2, ColorId =3, ModelYear = 2023, DailyPrice = 500,Description = " : Sports Car" },
                new Car {Id =4, BrandId = 5, ColorId = 6, ModelYear = 2022, DailyPrice = 700,Description = " : Luxury Car" },
                new Car {Id =7, BrandId = 8, ColorId = 9, ModelYear = 2019, DailyPrice = 250,Description = " : Economic Car" },
            };
        }
        public List<Car> GetAll() { return _cars; }
        public Car GetById(int id)
        {
            Car car = _cars.FirstOrDefault(c => c.Id == id);
            return car;
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(c => c.Id == car.Id);
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
            Car carToDelete = _cars.FirstOrDefault(c => c.Id == id);
            if (carToDelete != null)
            {
                _cars.Remove(carToDelete);
            }
        }
    }
}

