using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appdevery.Core.Data.EntityFramework
{
    public class EmailAddress
    {
        public string Email { get; set; }
        public int UserId { get; set; }
        public bool Verified { get; set; }
    }
}
