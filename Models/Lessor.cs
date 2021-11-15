using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Template.Models
{
    public class Lessor
    {
        public string Salutation { get; set; }
        public string Name_First { get; set; }
        public string Name_Last { get; set; }
        public string Name_Company { get; set; }
        public string Form_Company { get; set; }
        public Address address { get; set; }
        public string PhoneNumber_Private { get; set; }
        public string PhoneNumber_Business { get; set; }

        public Lessor(string salutation, string name_First, string name_Last, string name_Company, string form_Company, Address address, string phoneNumber_Private, string phoneNumber_Business)
        {
            Salutation = salutation;
            Name_First = name_First;
            Name_Last = name_Last;
            Name_Company = name_Company;
            Form_Company = form_Company;
            this.address = address;
            PhoneNumber_Private = phoneNumber_Private;
            PhoneNumber_Business = phoneNumber_Business;
        }
    }
}
