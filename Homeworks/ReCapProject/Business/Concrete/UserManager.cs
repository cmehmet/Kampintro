﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal) 
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            _userDal.Add(user);

            return new SuccessResult("Kullanıcı eklendi.");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);

            return new SuccessResult("Kullanıcı silindi."); 
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>> (_userDal.GetAll(), "Kullanıcılar listeledi.");
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == userId)); 
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);

            return new SuccessResult();
        }
    }
}
