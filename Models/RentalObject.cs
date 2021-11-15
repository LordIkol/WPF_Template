using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Template.Models
{

    public class RentalObject
    {
        private readonly List<Renter> _renters;

        private readonly Lessor _lessor;

        private readonly RenterMain _renterMain;

        public Address address { get; set; }
        public ContractInformation contract { get; set; }



        public RentalObject(Address address, ContractInformation contract,RenterMain mainrenter)
        {
            this.address = address;
            this.contract = contract;
            this._renters = new List<Renter>();
        }

        public RentalObject(Address address, ContractInformation contract, RenterMain mainrenter, Lessor lessor)
        {
            this.address = address;
            this.contract = contract;
            this._renters = new List<Renter>();
            this._lessor = lessor;
        }

        public RentalObject(Address address, ContractInformation contract, Lessor lessor, RenterMain mainrenter, List<Renter> renters)
        {
            this.address = address;
            this.contract = contract;
            this._renters = renters;
            this._lessor = lessor;
        }

    }
}
