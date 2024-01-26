using Core.Utilities.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetByUserId(int userId);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByMail(string email);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetUserByEmail(string email);
        IDataResult<User> GetById(int id);
        IResult EditProfil(User user, string password);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
