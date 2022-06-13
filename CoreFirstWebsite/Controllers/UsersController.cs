using CoreFirstWebsite.Models.Users;
using m2iWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreFirstWebsite.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            List<UserModel> allUsers = new List<UserModel>()
            {
                    new UserModel()
                    {
                        Id = 1,
                        Name = "ENRIE",
                        Surname = "Karine",
                        Mail = "karineEnrie@yopmail.com"
                    },
                    new UserModel()
                    {
                        Id = 1,
                        Name = "HADJIOUAL",
                        Surname = "Leila",
                        Mail = "HADJIOUALLeila@yopmail.com"
                    },new UserModel()
                    {
                        Id = 1,
                        Name = "NIBBIO",
                        Surname = "Julien",
                        Mail = "nibbioJulien@yopmail.com"
                    },
            };

            UsersListViewModel vm = new UsersListViewModel
            {
                ListUsers = allUsers
            };

            return View(vm);
        }
    }
}
