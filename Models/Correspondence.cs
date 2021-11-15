using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Template.Models
{
    public class Correspondence
    {
        public string Language { get; set; }
        public string EmailAddress { get; set; }
        public bool ByLetter { get; set; }
        public bool CopyLessor { get; set; }


        public Correspondence(string language, string emailAddress, bool byLetter, bool copyLessor)
        {
            Language = language;
            EmailAddress = emailAddress;
            ByLetter = byLetter;
            CopyLessor = copyLessor;
        }

    }
}
