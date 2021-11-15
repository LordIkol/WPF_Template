using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Template.Models
{
    public class RenterMain : Renter
    {
        public Address address { get; set; }
        public Correspondence correspondence { get; set; }
        public string PhoneNumber { get; set; }

        public RenterMain(string salutation, string Firstname_CompanyName, string Lastname_CompanyForm, int nationality, int domecile, DateTime birthdate_FoundingDate, int rentalObjectID, Address address, Correspondence correspondence, string phoneNumber) 
            : base(salutation, Firstname_CompanyName, Lastname_CompanyForm, nationality, domecile, birthdate_FoundingDate, rentalObjectID)
        {
            this.address = address;
            this.correspondence = correspondence;
            PhoneNumber = phoneNumber;
        }

        public RenterMain(string salutation, string Firstname_CompanyName, string Lastname_CompanyForm, int nationality, int domecile, DateTime birthdate_FoundingDate, int rentalObjectID)
            : base(salutation, Firstname_CompanyName, Lastname_CompanyForm, nationality, domecile, birthdate_FoundingDate, rentalObjectID)
        {

        }
    }
}
