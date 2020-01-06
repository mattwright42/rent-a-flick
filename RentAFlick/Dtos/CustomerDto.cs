using RentAFlick.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentAFlick.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToCustomer { get; set; }

        //byte = implicitly required
        public byte MembershipTypeId { get; set; }
        
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}