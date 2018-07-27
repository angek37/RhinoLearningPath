using System;

namespace BusinessType
{
    public class Account
    {
        public Guid AccountId { set; get; }
        public string Name { set; get; }
        public string City { set; get; }
        public string State { set; get; }
        public string Country { set; get; }
        public DateTime CreatedOn { set; get; }
    }
}
