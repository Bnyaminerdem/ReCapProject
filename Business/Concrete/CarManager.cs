﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Cathing;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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
        ICarDal _carDal;
        ICarImageService _carImageService;      

        public CarManager(ICarDal carDal, ICarImageService carImageService)
        {
            _carDal = carDal;
            _carImageService = carImageService;

        }
       
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            //Business codes
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice < 2000)
            {
                throw new Exception("");
            }

            Add(car);

            return null;
        }

        public IResult Delete(Car car)
        {
            var rulesResult = BusinessRules.Run(CheckIfCarIdExist(car.CarId));
            if (rulesResult != null)
            {
                return rulesResult;
            }

            var deletedCar = _carDal.Get(c => c.CarId == car.CarId);
            _carDal.Delete(deletedCar);
            return new SuccessResult(Messages.CarDeleted);
        }
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 7)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }
        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carId), Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarByBrandAndColor(int brandId, int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarByBrandAndColor(brandId, colorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {           
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.CarDetailsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsId(int carId)
        {
            List<CarDetailDto> carDetails = _carDal.GetCarDetails(c => c.CarId == carId);
            if (carDetails == null)
            {
                return new ErrorDataResult<List<CarDetailDto>>("");
            }
            else
            {
                return new SuccessDataResult<List<CarDetailDto>>(carDetails, "");
            }
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(b => b.BrandId == brandId));
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandIdWithDetails(int brandId)
        {
            List<CarDetailDto> carDetails = _carDal.GetCarDetails(c => c.BrandId == brandId);
            if (carDetails == null)
            {
                return new ErrorDataResult<List<CarDetailDto>>("");
            }
            else
            {
                return new SuccessDataResult<List<CarDetailDto>>(carDetails, "");
            }
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarsByColorIdWithDetails(int colorId)
        {
            List<CarDetailDto> carDetails = _carDal.GetCarDetails(c => c.ColorId == colorId);
            if (carDetails == null)
            {
                return new ErrorDataResult<List<CarDetailDto>>("");
            }
            else
            {
                return new SuccessDataResult<List<CarDetailDto>>(carDetails, "");
            }
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
        private IResult CheckIfCarIdExist(int carId)
        {
            var result = _carDal.GetAll(c => c.CarId == carId).Any();
            if (!result)
            {
                return new ErrorResult(Messages.CarNotExist);
            }
            return new SuccessResult();
        }
    }
}
