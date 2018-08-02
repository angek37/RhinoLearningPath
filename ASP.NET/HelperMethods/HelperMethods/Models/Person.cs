using System;
using System.ComponentModel.DataAnnotations;
using HelperMethods.Models.Metadata;

namespace HelperMethods.Models
{
    [MetadataType(typeof(PersonMetadata))]
    public partial class Person
    {
        public int PersonId { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime BirthDate { set; get; }
        public Address HomeAddress { set; get; }
        public bool IsApproved { set; get; }
        public Role Role { set; get; }
    }

    public class Address
    {
        public string Line1 { set; get; }
        public string Line2 { set; get; }
        public string City { set; get; }
        public string PostalCode { set; get; }
        public string Country { set; get; }
    }

    public enum Role
    {
        Admin,
        User,
        Guest
    }
}