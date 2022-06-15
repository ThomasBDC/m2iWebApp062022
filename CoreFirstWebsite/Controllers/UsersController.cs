using CoreFirstWebsite.Models.Users;
using m2iWebApp.Models;
using m2iWebApp.Repository.Users;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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

        public IActionResult GetUser(int idUser)
        {
            List<UserModel> allUsers = UsersRepository.getAllUsers();

            var monUser = allUsers.FirstOrDefault(u => u.Id == idUser);

            return View(monUser);
        }

        public IActionResult UsersAjax()
        {
            return View();
        }
    }
}
