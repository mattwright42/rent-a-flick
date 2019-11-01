using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentAFlick.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToCustomer { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}