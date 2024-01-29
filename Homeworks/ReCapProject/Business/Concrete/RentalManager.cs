using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var carToRent = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate.Equals(null));

            if (carToRent != null)
            {
                return new ErrorResult("Kiralamak istediğiniz araç müsait değil.");
            }

            _rentalDal.Add(rental);

            return new SuccessResult("Kiralama bilgisi eklendi.");
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);

            return new SuccessResult("Kiralama bilgisi silindi.");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), "Kiralama bilgileri listelendi.");
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentalId), "Kiralama bilgisi listelendi.");
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);

            return new SuccessResult("Kiralama bilgisi güncellendi.");
        }
    }
}
