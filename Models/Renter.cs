using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Template.Models
{
    public class Renter
    {
        public string Salutation { get; set; }
        public string Name_First { get; set; }
        public string Name_Last { get; set; }
        public string Name_Company { get; set; }
        public string Form_Company { get; set; }
        public int Nationality { get; set; }
        public int Domecile { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime Foundingdate { get; set; }
        public bool Cosima_Checked { get; set; }
        public string Cosima_Reference { get; set; }
        public int RentalObjectID {get; set; }

        public Renter(string salutation, string Firstname_CompanyName, string Lastname_CompanyForm, int nationality, int domecile, DateTime birthdate_FoundingDate, int rentalObjectID)
        {
            Salutation = salutation;
            Nationality = nationality;
            Domecile = domecile;
            RentalObjectID = rentalObjectID;

            if(salutation == "Firma")
            {
                Name_Company = Firstname_CompanyName;
                Form_Company = Lastname_CompanyForm;
                Foundingdate = birthdate_FoundingDate;
            }
            else
            {
                Name_First = Firstname_CompanyName;
                Name_Last = Lastname_CompanyForm;
                Birthdate = birthdate_FoundingDate;
            }
           
        }


    }
}
