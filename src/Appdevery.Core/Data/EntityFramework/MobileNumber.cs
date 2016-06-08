using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appdevery.Core.Data.EntityFramework
{
    public class MobileNumber
    {
        public string CountryCode { get; set; }
        public string Number { get; set; }
        public int UserId { get; set; }
        public bool Verified { get; set; }
    }
}
