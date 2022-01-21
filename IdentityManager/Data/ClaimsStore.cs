using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityManager.Data
{
    public class ClaimsStore
    {
        public static List<Claim> claimsList = new List<Claim>()
        {
            new Claim("Create", "Create"),
            new Claim("Edit", "Edit"),
            new Claim("Delete", "Delete")
        };
    }
}
