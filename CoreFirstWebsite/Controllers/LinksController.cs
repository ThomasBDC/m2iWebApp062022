using CoreFirstWebsite.Models.Links;
using m2iWebApp.Models;
using m2iWebApp.Repository.Links;
using m2iWebApp.Repository.Users;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CoreFirstWebsite.Controllers
{
    public class LinksController : Controller
    {
        [Route("/AfficheMoiLesLienMonCoco")]
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


        public IActionResult Link(int idLien)
        {
            //On récupère tous les liens
            List<LinkModel> allLinks = LinksRepository.getAllLinks();

            //On fait la recherche de notre lien
            LinkModel monLien = null;
            foreach(var lien in allLinks)
            {
                if(lien.Id == idLien)
                {
                    monLien = lien;
                }
            }
 
            //Si j'ai pas trouvé de lien, je renvoie une 404
            if(monLien == null)
            {
                return NotFound();
            }
            else //Sinon, je renvoie ma vue
            {
                return View(monLien);
            }

        }
    }
}
