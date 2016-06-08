using System;

namespace Appdevery.Core.Data.EntityFramework
{
    public class User
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
