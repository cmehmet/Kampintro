using InterfaceAbstractDemo.Abstracts;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concretes;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;

namespace InterfaceAbstractDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "--------",//Your FirstName
                LastName = "--------",//Your LastName
                NationalId = "-----------",//Your 11 digit T.C Idendity Number
                DateOfBirth = new DateTime(YYYY, MM, DD)//Your Birthdate

                BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServisAdapter());
                customerManager.Save(customer1);
        }
        }
    }
}
