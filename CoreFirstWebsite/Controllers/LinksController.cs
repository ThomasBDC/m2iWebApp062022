using CoreFirstWebsite.Models.Links;
using m2iWebApp.Models;
using m2iWebApp.Repository.Links;
using m2iWebApp.Repository.Users;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreFirstWebsite.Controllers
{
    public class LinksController : Controller
    {
        public IActionResult Index()
        {
            //J'appelle mon modèle de domaine
            List<LinkModel> allLinks = LinksRepository.getAllLinks();
            List<UserModel> allUsers = UsersRepository.getAllUsers();

            //Je transforme mon modèle de domaine en modèle de vue
            LinksListViewModel vm = new LinksListViewModel
            {
                AllLinks = allLinks,
                AllUsers = allUsers
            };

            //J'inclus mon modèle dans la vue
            return View(vm);
        }
    }
}
