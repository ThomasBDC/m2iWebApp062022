using m2iWebApp.Models;
using System.Collections.Generic;

namespace CoreFirstWebsite.Models.Links
{
    public class LinksListViewModel
    {
        public List<LinkModel> AllLinks { get; set; }
        public List<UserModel> AllUsers { get; set; }
    }
}
