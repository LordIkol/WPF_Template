using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Template.Models
{
    public class ContractInformation
    {
    
        public int DepositAmount { get; set; }
        public DateTime ContractStart { get; set; }
        public bool AccoundholderMoves { get; set; }

        public ContractInformation(int depositAmount, DateTime contractStart, bool accoundholderMoves)
        {
            DepositAmount = depositAmount;
            ContractStart = contractStart;
            AccoundholderMoves = accoundholderMoves;
        }
    }
}
