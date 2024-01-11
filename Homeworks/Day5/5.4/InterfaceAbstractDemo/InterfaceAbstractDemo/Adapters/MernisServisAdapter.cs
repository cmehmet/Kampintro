using InterfaceAbstractDemo.Abstracts;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServisAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response =client.TCKimlikNoDogrulaAsync(
                                Convert.ToInt64(customer.NationalId),
                                customer.FirstName.ToUpper(),
                                customer.LastName.ToUpper(),
                                customer.DateOfBirth.Year);
            bool result = response.Result.Body.TCKimlikNoDogrulaResult;
            return result;
            

        }
    }
}


//
//
//
//KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
//Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalId), customer.FirstName, customer.LastName, customer.DateOfBirth.Year);
//return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
