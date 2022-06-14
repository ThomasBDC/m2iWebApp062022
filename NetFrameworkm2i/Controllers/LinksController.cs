using NetFrameworkm2i.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFrameworkm2i.Controllers
{
    public class LinksController : Controller
    {
        // GET: Links
        public ActionResult Index()
        {
            var allLinks = LinksRepository.getAllLinks();

            var vm = new LinkViewModel()
            {
                AllLinks = allLinks
            };

            return View(vm);
        }
    }
}