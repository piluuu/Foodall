using Foodall.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foodall.Services
{
    public interface IRepository
    {
        //CRUD contract
        IEnumerable<Member> GetMembers();
        Member GetMember(int memberId);
      
        //TODO rest of the CRUD TBD

    }
}
