using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
   public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
            new Car { BrandId = 1, ColorId = 2, Id = 1, ModelYear = 2021, DailyPrice = 370, Description = "Tesla Model S, Elektirikli Sedan" }
                ,new Car { BrandId = 2, ColorId = 1, Id = 1, ModelYear = 2020, DailyPrice = 500, Description = "Mercedes S500d, Dizel Sedan" }
                ,new Car { BrandId = 3, ColorId = 3, Id = 1, ModelYear = 2021, DailyPrice = 320, Description = "Volkswagen ID4, Elektirikli SUV" }
                ,new Car { BrandId = 4, ColorId = 5, Id = 1, ModelYear = 2019, DailyPrice = 150, Description = "Renault Clio 5 1.3TCe, Benzinli HatchBack" }
        };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == c.Id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
