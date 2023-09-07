﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        public void AddCar(Car car)
        {
            if (car.CarName.Length < 2)
            {
                throw new Exception("Araba ismi minimum 2 karakter olmalıdır.");
                return;
            }
            if (car.DailyPrice <= 0)
            {
                throw new Exception("Araba günlük fiyatı 0'dan büyük olmalıdır.");
                return;
            }

            _carDal.Add(car);
        }

        public void DeleteCar(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
           return _carDal.Get(c => c.CarId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
           return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void UpdateCar(Car car)
        {
            _carDal.Update(car);
        }
    }
}
