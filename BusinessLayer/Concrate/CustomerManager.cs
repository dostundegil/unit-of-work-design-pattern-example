﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUowDal _uowDal;

        public CustomerManager(ICustomerDal customerDal, IUowDal uowDal)
        {
            _customerDal = customerDal;
            _uowDal = uowDal;
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
            _uowDal.Save();
        }

        public Customer TGetByID(int id)
        {
            return _customerDal.GetByID(id);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<Customer> t)
        {
            _customerDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
            _uowDal.Save();
        }
    }
}
