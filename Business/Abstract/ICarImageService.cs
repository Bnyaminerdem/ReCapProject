using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;


namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetByImageId(int imageId);
        IDataResult<List<CarImage>> GetByCarId(int carId);
        Core.Utilities.Results.Abstract.IResult Add(IFormFile file, CarImage carImage);
        Core.Utilities.Results.Abstract.IResult Delete(CarImage carImage);
        Core.Utilities.Results.Abstract.IResult Update(IFormFile file, CarImage carImage);
    }
}

