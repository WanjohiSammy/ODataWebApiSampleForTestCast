using System.Collections.Generic;

namespace ODataWebApiSample.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address? Location { get; set; } = null;
        public List<Order> Orders { get; set; } = new List<Order>();
    }

    public class DerivedCustomer : Customer
    {
        public string DerivedProperty { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
    }

    public class HomeAddress : Address
    {
        public string Street { get; set; }
    }
}
