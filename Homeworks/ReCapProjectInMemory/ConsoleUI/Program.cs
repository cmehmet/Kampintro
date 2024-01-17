using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System.Drawing;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            //Insert
            carManager.Add(new Car {Id = 5,BrandId = 5, ColorId = 3, ModelYear = 2022, DailyPrice = 4500, Description = "Middle Pack" });
            carManager.Add(new Car {Id = 6,BrandId = 3, ColorId = 4, ModelYear = 2023, DailyPrice = 6000, Description = "Premium Pack" });

            //Select
            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine("Id : " + car.Id +
                                  "\nBrand Id : " + car.BrandId +
                                  "\nColor Id : " + car.ColorId +
                                  "\nModel Year : " + car.ModelYear +
                                  "\nDaily Price : " + car.DailyPrice +
                                  "\nDescription : " + car.Description);
                Console.WriteLine();
            }

            //Update
            carManager.Update(new Car { Id = 5, BrandId = 2, ColorId = 1, ModelYear = 2021, DailyPrice = 3000, Description = "Middle Pack" });

            Console.WriteLine("Updated---------------------");
            //Select (By Id)
            Car car1 = carManager.GetById(5);
            Console.WriteLine("Id : " + car1.Id +
                              "\nBrand Id : " + car1.BrandId +
                              "\nColor Id: " + car1.ColorId +
                              "\nModel Year : " + car1.ModelYear +
                              "\nDaily Price : " + car1.DailyPrice +
                              "\nDescription : " + car1.Description);

            //Delete
            carManager.Delete(6);
            Console.WriteLine("Deleted(Id=6)---------------------");
            //Checking

            Console.WriteLine("Checking---------------------");

            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine("Id : " + car.Id +
                                  "\nBrand Id : " + car.BrandId +
                                  "\nColor Id : " + car.ColorId +
                                  "\nModel Year : " + car.ModelYear +
                                  "\nDaily Price : " + car.DailyPrice +
                                  "\nDescription : " + car.Description);
                Console.WriteLine();
            }


        }
    }
}
