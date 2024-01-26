using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapDBContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalsDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from rent in context.Rentals
                             join car in context.Cars
                       on rent.CarId equals car.CarId
                             join customer in context.Customers
                                 on rent.CustomerId equals customer.CustomerId
                             join user in context.Users
                                 on customer.UserId equals user.Id
                             join brand in context.Brands
                                 on car.BrandId equals brand.BrandId
                             select new RentalDetailDto
                             {
                                 RentalId = rent.RentalId,
                                 CarId = car.CarId,
                                 ModelFullName = $"{brand.BrandName} {car.CarName}",
                                 CustomerId = customer.CustomerId,
                                 CustomerFullName = $"{user.FirstName} {user.LastName}",
                                 ReturnDate = rent.ReturnDate,
                                 DailyPrice = car.DailyPrice,
                                 RentDate = rent.RentDate,                                
                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }
    }
}
