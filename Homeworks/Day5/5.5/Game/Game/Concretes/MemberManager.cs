using Game.Abstracts;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Concretes
{
    internal class MemberManager : IMemberService
    {
        private IServiceAdapter serviceAdapter;
        public MemberManager(IServiceAdapter serviceAdapter) 
        {
            this.serviceAdapter = serviceAdapter;//
        }
        public void Add(Member member)
        {

            Console.WriteLine("Kayıt oluşturuldu");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Member member)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
