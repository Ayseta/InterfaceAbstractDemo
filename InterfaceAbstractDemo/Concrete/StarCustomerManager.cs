﻿using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarCustomerManager(ICustomerCheckService customerCheckService) 
        {
            _customerCheckService = customerCheckService;
        }
       public override void Save (Customer customer) 
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }

        }
    }
}
