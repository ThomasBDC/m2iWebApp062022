using CoreFirstWebsite.Models.Links;
using m2iWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreFirstWebsite.Controllers
{
    public class LinksController : Controller
    {
        public IActionResult Index()
        {
            //J'appelle mon modèle de domaine
            List<LinkModel> allLinks = new List<LinkModel>()
            {
                    new LinkModel()
                    {
                        Id = 1,
                        Name = "Code My UI",
                        Description = "Site avec des Liens pour le dev",
                        Url = "https://codemyui.com"
                    },
                    new LinkModel()
                    {
                        Id = 2,
                        Name = "Exercism",
                        Description = "Site avec des exos pour le dev",
                        Url = "https://exercism.com"
                    },
            };
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
