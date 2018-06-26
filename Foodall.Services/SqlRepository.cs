using System;
using System.Collections.Generic;
using System.Text;
using Foodall.Data;
using Foodall.Domain;

namespace Foodall.Services
{
    public class SqlRepository : IRepository
    {

        private FoodallContext _context;

        public SqlRepository(FoodallContext context)
        {
            _context = context;
        }

        public Member GetMember(int memberId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> GetMembers()
        {
            throw new NotImplementedException();
        }
    }
}
