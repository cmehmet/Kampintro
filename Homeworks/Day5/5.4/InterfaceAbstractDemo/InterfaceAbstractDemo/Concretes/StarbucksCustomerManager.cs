using InterfaceAbstractDemo.Abstracts;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concretes
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            this.customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            //Mernis Doğrulaması
            if (customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Geçerli kullanıcı değil.");
            }
            
            
        }

    }
}
