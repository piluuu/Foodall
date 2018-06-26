using System;
using System.Collections.Generic;
using System.Linq;
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
            return _context.Members.FirstOrDefault(m => m.Id == memberId);
        }

        public IEnumerable<Member> GetMembers()
        {
            return _context.Members.OrderBy(m => m.Name);
        }
    }
}
