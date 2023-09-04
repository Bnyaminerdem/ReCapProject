using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Update.Internal;
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
            CarManager carManager = new CarManager(new EfCarDal());
            //Car car1 = new Car();
            //car1.CarName = "testcar";
            //car1.Id = 7;
            //car1.BrandId = 7;
            //car1.ModelYear = 2015;
            //car1.ColorId = 7;
            //car1.DailyPrice = 1000;
            //car1.Description = "suv";
            //carManager.AddCar(car1);

            //Car car2= carManager.GetCarById(7);
            //car2.CarName = "textupdate";
            //carManager.UpdateCar(car2);

            //carManager.DeleteCar(car2);

            //foreach (var car in carManager.GetAllCars())
            //{
            //    Console.WriteLine(car.CarName);
            //}
        }
    }
}