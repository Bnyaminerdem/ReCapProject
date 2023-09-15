using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();      
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int Id);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int Id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetById(int id);
        IResult AddCar(Car car);
        IResult UpdateCar(Car car);
        IResult DeleteCar(Car car);       
    }
}
