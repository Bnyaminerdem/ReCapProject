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
            CarTest();                 
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result =carManager.GetCarDetails();
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
    }
}