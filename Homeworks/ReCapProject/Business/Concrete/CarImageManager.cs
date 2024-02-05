using Autofac.Core.Lifetime;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            var result = BusinessRules.Run(CheckIfCarImageLimitExceeded(carImage.CarId));
            
            if (result != null)
            {
                return result;
            }

            carImage.ImagePath = _fileHelper.Upload(file, Roots.ImagesPath);
            carImage.Date = DateTime.Now;

            _carImageDal.Add(carImage);

            return new SuccessResult(Messages.CarImageUploaded);
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = _fileHelper.Update(file, Roots.ImagesPath, Roots.ImagesPath + carImage.ImagePath);
            carImage.Date = DateTime.Now;

            _carImageDal.Update(carImage);

            return new SuccessResult(Messages.CarImageUpdated);
        }


        public IResult Delete(CarImage carImage)
        {
            _fileHelper.Delete(Roots.ImagesPath + carImage.ImagePath);

            _carImageDal.Delete(carImage);

            return new SuccessResult(Messages.CarImageDeleted);
        }


        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(),Messages.CarImagesListed);
        }

        public IDataResult<List<CarImage>> GetAllByCarId(int carId)
        {
            var result = BusinessRules.Run(CheckIfCarImageExists(carId));

            if (result != null)
            {
                return GetDefaultImage(carId);
            }

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(ci => ci.CarId == carId));
            
        }

        #region
        private IResult CheckIfCarImageLimitExceeded(int carId)
        {
            var result = GetAll();
            if (result.Data.Count >= 5)
            {
                return new ErrorResult(Messages.CarImageLimitExceeded);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCarImageExists(int carId)
        {
            var result = _carImageDal.GetAll(ci => ci.CarId == carId);
            if (result.Count == 0)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        private IDataResult<List<CarImage>> GetDefaultImage(int carId)
        {
            List<CarImage> defaultCarImage = new List<CarImage> { new CarImage { CarId = carId, ImagePath = "DefaultImage.jpg" } };
            return new ErrorDataResult<List<CarImage>>(defaultCarImage, Messages.NoCarImage);
        }

        #endregion
    }
}
