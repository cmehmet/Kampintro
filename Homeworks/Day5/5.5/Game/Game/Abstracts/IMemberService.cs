using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Abstracts
{
    internal interface IMemberService
    {
        void Add(Member member);
        void Update (Member member);
        void Delete (int id);
    }
}
