using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Abstracts;
using Game.Entities;
using MernisServiceReference;

namespace Game.Adapters
{
    public class MernisServisAdapter : IServiceAdapter
    {
        public bool CheckIfRealMember(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(member.NatiaonalityId), member.FirstName, member.LastName, member.DateOfBirth.Year);
            bool result = response.Result.Body.TCKimlikNoDogrulaResult;
            return result;
        }
        
    }
}
