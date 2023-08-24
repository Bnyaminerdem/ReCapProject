using ReCapProject.Business.Abstract;
using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Concrete;
using ReCapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarManager(new InMemoryCarDal());

            carService.AddCar(new Entities.Car { Id = 4, BrandId = 4, ColorId = 4, ModelYear = 2021, DailyPrice = 600, Description =  " : Super Car" });
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("All The Cars You Yan Rent");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            foreach (var car in carService.GetAllCars())
            {
                Console.WriteLine($"Car Id: {car.Id}\nBrand Id: {car.BrandId}\nColor Id {car.ColorId}\nModel Year {car.ModelYear}\nDaily Price: {car.DailyPrice}\nDescription{car.Description}\n");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Below İs The Car İnformation Found");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            int searchId = 4;
            Car foundCar = carService.GetCarById(searchId);
            if (foundCar != null)
            {
                Console.WriteLine($"Found Car: Id: {foundCar.Id}\nBrand Id: {foundCar.BrandId}\nColor Id: {foundCar.ColorId}\nModel Year: {foundCar.ModelYear}\nDaily Price: {foundCar.DailyPrice}\nDescription{foundCar.Description}\n");
            }
            else
            {
                Console.WriteLine($"Car with Id {searchId} not found.");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Updated Car");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Car carToUpdate = carService.GetCarById(1);
            carToUpdate.DailyPrice = 1000;
            carService.UpdateCar(carToUpdate);
        
            Console.WriteLine($"Id: {carToUpdate.Id}\nBrand Id: {carToUpdate.BrandId}\nColor Id: {carToUpdate.ColorId}\nModel Year: {carToUpdate.ModelYear}\nDaily Price: {carToUpdate.DailyPrice}\nDescription{carToUpdate.Description}\n");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("After Transactions");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            int carToDeleteId = 3;
            carService.DeleteCar(carToDeleteId);
            
            foreach (var car in carService.GetAllCars())
            {
                Console.WriteLine($"Car Id: {car.Id}\nBrand Id: {car.BrandId}\nColor Id: {car.ColorId}\nModel Year: {car.ModelYear}\nDaily Price: {car.DailyPrice}\nDescription{car.Description}\n");
            }

        }
    }
}
