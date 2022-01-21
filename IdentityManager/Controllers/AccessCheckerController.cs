using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Controllers
{
    [Authorize]
    public class AccessCheckerController : Controller
    {
        [AllowAnonymous]
        //accessable by all, even users not logged-in
        public IActionResult AllAccess()
        {
            return View();
        }

        //accessable by logged-in users
        public IActionResult AuthorizedAccess()
        {
            return View();
        }

        [Authorize(Roles = "User")]
        //accessable by users who have user role
        public IActionResult UserAccess()
        {
            return View();
        }


        [Authorize(Roles = "User, Admin")]
        //accessable by users who have user role
        public IActionResult UserORAdminAccess()
        {
            return View();
        }

        //if user has both admin and user role then role based cannot support that so use policy
        [Authorize(Policy = "UserAndAdmin")]
        //accessable by users who have user role
        public IActionResult UserANDAdminAccess()
        {
            return View();
        }



        [Authorize(Policy = "Admin")]
        //accessable by users who have admin role
        public IActionResult AdminAccess()
        {
            return View();
        }

        //accessable by Admin who have claim of create to be true
        public IActionResult Admin_CreateAccess()
        {
            return View();
        }

        //accessable by Admin user with create, edit and delete (AND NOT OR)
        public IActionResult Admin_Create_Edit_DeleteAccess()
        {
            return View();
        }

        //accessable by Admin user with create, edit and delete (AND NOT OR), OR if the user role is superAdmin
        public IActionResult Admin_Create_Edit_DeleteAccess_SuperAdmin()
        {
            return View();
        }



    }
}
