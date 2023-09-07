using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Microsoft.IdentityModel.Protocols;
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
            //ColorTest();
            //BrandTest();          
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarName + "/" + car.ColorName);
            //}
            //Car carTest = carManager.GetById(1);
            //Console.WriteLine(carTest.CarName + "/" + carTest.CarId);
            //Car carTest = new Car();
            //carTest.CarName = "testcar";
            //carTest.CarId = 7;
            //carTest.BrandId = 7;
            //carTest.ModelYear = 2015;
            //carTest.ColorId = 7;
            //carTest.DailyPrice = 1000;
            //carTest.Description = "suv";
            //carManager.AddCar(carTest);
            //carManager.DeleteCar(carTest);


            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName);
            //}

        }
        private static void ColorTest() 
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName + "/" + color.ColorId);
            //}
            //Color colorTest = colorManager.GetById(1);
            //Console.WriteLine(colorTest.ColorName + "/" + colorTest.ColorId);         
        }
        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach ( var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName +"/"+ brand.BrandId);
            //}
            //Brand brandTest = brandManager.GetById(1);
            //Console.WriteLine(brandTest.BrandName + "/" + brandTest.BrandId);
        }
    }
}