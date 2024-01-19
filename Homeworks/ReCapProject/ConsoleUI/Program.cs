using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Drawing;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());

            //CarAddTest(carManager);

            //CarGetAllTest(carManager);

            //GetCarsByBranIdTest(carManager);

            //GetCarsByColorIdTest(carManager);

            //CarUpdateTest(carManager);

            //CarGetTest(carManager);

            //CarDeleteTest(carManager);

            //CarGetCarDetails(carManager);

            /*
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandName = "Nissan" });
            brandManager.Update(new Brand {BrandId = 5, BrandName = "Lexus"});
            */


        }

        private static void CarGetCarDetails(CarManager carManager)
        {
            foreach (var carDetail in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} {1} - {2} - {3}", carDetail.BrandName,
                                                        carDetail.CarName,
                                                        carDetail.ColorName,
                                                        carDetail.DailyPrice);
            }
        }

        private static void CarDeleteTest(CarManager carManager)
        {
            //Delete
            carManager.Delete(new Car { Id = 9, BrandId = 4, CarName = "Qashqai", ColorId = 4, ModelYear = 2014, DailyPrice = 2000, Description = "Middle Pack" });
            Console.WriteLine("Deleted");
        }

        private static void CarGetTest(CarManager carManager)
        {
            //Select (By Id)
            Car car = carManager.Get(5).Data;
            Console.WriteLine("Id : " + car.Id +
                              "\nBrand Id : " + car.BrandId +
                              "\nColor Id: " + car.ColorId +
                              "\nCar Name : " + car.CarName +
                              "\nModel Year : " + car.ModelYear +
                              "\nDaily Price : " + car.DailyPrice +
                              "\nDescription : " + car.Description);
        }

        private static void CarUpdateTest(CarManager carManager)
        {
            //Update
            carManager.Update(new Car { Id = 5, BrandId = 4, CarName = "Skyline R34", ColorId = 4, ModelYear = 1999, DailyPrice = 7750, Description = "Premium Pack" });
            Console.WriteLine("Updated");
        }

        private static void GetCarsByColorIdTest(CarManager carManager)
        {
            foreach (Car car in carManager.GetCarsByColorId(3).Data)
            {
                Console.WriteLine("Id : " + car.Id +
                                  "\nBrand Id : " + car.BrandId +
                                  "\nColor Id : " + car.ColorId +
                                  "\nCar Name : " + car.CarName +
                                  "\nModel Year : " + car.ModelYear +
                                  "\nDaily Price : " + car.DailyPrice +
                                  "\nDescription : " + car.Description);
                Console.WriteLine();
            }
        }

        private static void GetCarsByBranIdTest(CarManager carManager)
        {
            foreach (Car car in carManager.GetCarsByBrandId(2).Data)
            {
                Console.WriteLine("Id : " + car.Id +
                                  "\nBrand Id : " + car.BrandId +
                                  "\nColor Id : " + car.ColorId +
                                  "\nCar Name : " + car.CarName +
                                  "\nModel Year : " + car.ModelYear +
                                  "\nDaily Price : " + car.DailyPrice +
                                  "\nDescription : " + car.Description);
                Console.WriteLine();
            }
        }

        private static void CarGetAllTest(CarManager carManager)
        {
            //Select
            foreach (Car car in carManager.GetAll().Data)
            {
                Console.WriteLine("Id : " + car.Id +
                                  "\nBrand Id : " + car.BrandId +
                                  "\nColor Id : " + car.ColorId +
                                  "\nCar Name : " + car.CarName +
                                  "\nModel Year : " + car.ModelYear +
                                  "\nDaily Price : " + car.DailyPrice +
                                  "\nDescription : " + car.Description);
                Console.WriteLine();
            }
        }

        private static void CarAddTest(CarManager carManager)
        {
            //Insert
            carManager.Add(new Car { BrandId = 5, ColorId = 3, CarName = "LFA", ModelYear = 2022, DailyPrice = 6250, Description = "Premium Pack" });
        }
    }
}
