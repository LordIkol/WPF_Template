using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Template.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public Address(string street, string number, int zipCode, string city)
        {
            Street = street;
            Number = number;
            ZipCode = zipCode;
            City = city;
        }

    }
}
