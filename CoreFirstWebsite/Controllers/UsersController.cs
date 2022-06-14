using CoreFirstWebsite.Models.Users;
using m2iWebApp.Models;
using m2iWebApp.Repository.Users;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreFirstWebsite.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            List<UserModel> allUsers = UsersRepository.getAllUsers();

            UsersListViewModel vm = new UsersListViewModel
            {
                ListUsers = allUsers
            };

            return View(vm);
        }
    }
}
