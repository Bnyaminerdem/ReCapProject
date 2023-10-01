using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Microsoft.IdentityModel.Protocols;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Services.Implement;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //DeleteCarTest();
            UserTest();
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            User user1 = new User
            {
                Id = 1,
                FirstName = "Bünyamin",
                LastName = "Çiftçi",
                Email = "berdem@gmail.com",
                Password = "berdem123*"
            };    

            userManager.Add(user1);
        }
        private static void DeleteCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var carDelet = carManager.GetById(9);
            carManager.Delete(carDelet.Data);
            Console.WriteLine(carDelet.Message);
        }
    }
}