using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from a in context.Cars
                             join c in context.Colors
                             on a.ColorId equals c.Id
                             select new CarDetailDto
                             {
                                 CarId = a.Id,
                                 CarName = a.Name,
                                 ColorId = c.Id,
                                 ColorName = c.ColorName,
                                 DailyPrice = a.DailyPrice,
                             };
                return result.ToList();
            }
        }
    }
}