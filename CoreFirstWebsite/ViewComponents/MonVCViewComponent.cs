using CoreFirstWebsite.Models.Links;
using m2iWebApp.Repository.Links;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreFirstWebsite
{
    public class MonVCViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Mettre du code C#

            var allLinks = LinksRepository.getAllLinks();

            var vm = new LinksListViewModel
            {
                AllLinks = allLinks
            };

            //Ici on peut passer un modèle à la vue
            return View("ViewOfMyVC", vm);
        }
    }
}
