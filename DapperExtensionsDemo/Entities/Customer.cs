using System;

namespace DapperExtensionsDemo.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}