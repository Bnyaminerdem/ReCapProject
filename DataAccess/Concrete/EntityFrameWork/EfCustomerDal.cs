using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapDBContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var customerDetail = from c in context.Customers
                                     join u in context.Users
                                     on c.UserId equals u.Id
                                     select new CustomerDetailDto
                                     {
                                         CompanyName = c.CompanyName,
                                         CustomerId = c.CustomerId,
                                         Email = u.Email,
                                         FirstName = u.FirstName,
                                         LastName = u.LastName,
                                     };
                return customerDetail.ToList();
            }
        }
    }
}
