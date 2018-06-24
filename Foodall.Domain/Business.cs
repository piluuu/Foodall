using System;
using System.Collections.Generic;
using System.Text;

namespace Foodall.Domain
{
    public class Business
    {
        public Business()
        {
            MenuItems = new List<MenuItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public int MemberId { get; set; }
    }
}
