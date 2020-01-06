using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RentAFlick.Dtos
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        //protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //{
        //    var customer = (CustomerDto)validationContext.ObjectInstance;

        //    if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
        //    {
        //        return ValidationResult.Success;
        //    }
        //    else if (customer.Birthdate == null)
        //    {
        //        return new ValidationResult("Birthdate is required.");
        //    }

        //    var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
        //    return (age >= 18)
        //        ? ValidationResult.Success
        //        : new ValidationResult("Customer must be 18 years of age to subscribe to this plan.");
        //}
    }
}