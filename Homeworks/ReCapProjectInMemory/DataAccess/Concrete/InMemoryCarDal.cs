using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;
        public InMemoryCarDal() 
        {
            cars = new List<Car>
            {
                new Car {Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2016, DailyPrice = 2000, Description = "Beginner Pack"},
                new Car {Id = 2, BrandId = 1, ColorId = 2, ModelYear = 2018, DailyPrice = 3500, Description = "Middle Pack"},
                new Car {Id = 3, BrandId = 2, ColorId = 4, ModelYear = 2014, DailyPrice = 1700, Description = "Beginner Pack"},
                new Car {Id = 4, BrandId = 3, ColorId = 3, ModelYear = 2021, DailyPrice = 4700, Description = "Premium Pack"}

            };
        }
        public Car GetById(int id)
        {
            return cars.Single(car => car.Id == id);
        }

        public List<Car> GetAll()
        {
            return cars.Where(car => car.Id != null).ToList();
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Delete(int id)
        {
            Car carToDelete;
            carToDelete = cars.Single(c => c.Id == id);
            cars.Remove(carToDelete);
        }
    }
}
