using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreFirstWebsite.ViewComponents
{
    public class ModalViewModel
    {
        public ModalViewModel(string titre, string contenu)
        {
            Titre = titre;
            Contenu = contenu;
        }

        public string Titre { get; set; }
        public string Contenu { get; set; }
    }

    public class ModalViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ModalViewModel vm)
        {

            //Ici on peut passer un modèle à la vue
            return View("ModalView", vm);
        }
    }
}
