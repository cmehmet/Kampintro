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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());


            //----------Rental----------//

            //RentalAddTest(rentalManager);

            //RentalGetAllTest(rentalManager);

            //Console.WriteLine(rentalManager.GetById(1).Data.CarId) ;


            //----------Customer----------//
            
            //CustomerGetAllTest(customerManager);


            //----------Car----------//

            //CarAddTest(carManager);

            //CarGetAllTest(carManager);

            //GetCarsByBranIdTest(carManager);

            //GetCarsByColorIdTest(carManager);

            //CarUpdateTest(carManager);

            //CarGetTest(carManager);

            //CarDeleteTest(carManager);

            //CarGetCarDetails(carManager);


            //----------Brand----------//

            //BrandAddTest(brandManager);

            //BrandUpdateTest(brandManager);


            //----------User----------//

            //UserGetAllTest(userManager);

            //UserAddTest(userManager);

            //UserDeleteTest(userManager);

        }

        private static void RentalGetAllTest(RentalManager rentalManager)
        {
            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4}", rental.Id, rental.CarId, rental.CustomerId, rental.RentDate, rental.ReturnDate);

            }
        }

        private static void CustomerGetAllTest(CustomerManager customerManager)
        {
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine("{0} - {1} - {2}", customer.Id, customer.UserID, customer.CompanyName);
            }
        }

        private static void RentalAddTest(RentalManager rentalManager)
        {
            var result = rentalManager.Add(new Rental { CarId = 5, CustomerId = 2, RentDate = DateTime.Now });
            Console.WriteLine(result.Message);
        }

        private static void UserDeleteTest(UserManager userManager)
        {
            userManager.Delete(new User
            {
                Id = 5,
                FirstName = "Özkan",
                LastName = "Ruşan",
                Email = "ozkanrusan@gmail.com",
                Password = "123bca"
            });
        }

        private static void BrandUpdateTest(BrandManager brandManager)
        {
            brandManager.Update(new Brand { BrandId = 5, BrandName = "Lexus" });
        }

        private static void BrandAddTest(BrandManager brandManager)
        {
            brandManager.Add(new Brand { BrandName = "Nissan" });
        }

        private static void UserAddTest(UserManager userManager)
        {
            userManager.Add(new User { FirstName = "Özkan", LastName = "Ruşan", Email = "ozkanrusan@gmail.com", Password = "123bca" });
        }

        private static void UserGetAllTest(UserManager userManager)
        {
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine("{0} - {1} {2} - {3} - {4}", user.Id, user.FirstName, user.LastName, user.Email, user.Password);
            }
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

        //Delete
        private static void CarDeleteTest(CarManager carManager)
        {
            
            carManager.Delete(new Car { Id = 9, BrandId = 4, CarName = "Qashqai", ColorId = 4, ModelYear = 2014, DailyPrice = 2000, Description = "Middle Pack" });
            Console.WriteLine("Deleted");
        }

        //Select (By Id)
        private static void CarGetTest(CarManager carManager)
        {
            
            Car car = carManager.Get(5).Data;
            Console.WriteLine("Id : " + car.Id +
                              "\nBrand Id : " + car.BrandId +
                              "\nColor Id: " + car.ColorId +
                              "\nCar Name : " + car.CarName +
                              "\nModel Year : " + car.ModelYear +
                              "\nDaily Price : " + car.DailyPrice +
                              "\nDescription : " + car.Description);
        }

        //Update
        private static void CarUpdateTest(CarManager carManager)
        {
            
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

        //Select
        private static void CarGetAllTest(CarManager carManager)
        {
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

        //Insert
        private static void CarAddTest(CarManager carManager)
        { 
            carManager.Add(new Car { BrandId = 5, ColorId = 3, CarName = "LFA", ModelYear = 2022, DailyPrice = 6250, Description = "Premium Pack" });
        }
    }
}
