using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseCustomerManager customerManager = new NeroCustomerManager();
            
            BaseCustomerManager customerManager = new StarCustomerManager(new MernisServiceAdapter());
           
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1500,1,1), FirstName="Çoban Kaldi",LastName="Etiyopya",NationalityId="12345678910" });
            Console.ReadLine();
        }
    }
}
