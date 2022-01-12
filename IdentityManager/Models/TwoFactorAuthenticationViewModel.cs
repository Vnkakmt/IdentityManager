using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Models
{
    public class TwoFactorAuthenticationViewModel
    {
        //used to login
        public string code { get; set; }

        //used to register/ signup
        public string Token { get; set; }
    }
}
