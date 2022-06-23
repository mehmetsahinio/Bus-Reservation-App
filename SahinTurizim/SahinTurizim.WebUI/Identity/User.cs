using System;
using Microsoft.AspNetCore.Identity;

namespace SahinTurizim.WebUI.Identity
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
