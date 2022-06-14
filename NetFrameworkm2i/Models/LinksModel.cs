using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFrameworkm2i.Models
{
    public class LinksModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }

    public class LinkViewModel
    {
        public List<LinksModel> AllLinks { get; set; }
    }

    public static class LinksRepository
    {
        public static List<LinksModel> getAllLinks()
        {
            return new List<LinksModel>()
            {
                    new LinksModel()
                    {
                        Id = 1,
                        Name = "Code My UI",
                        Description = "Site avec des Liens pour le dev",
                        Url = "https://codemyui.com"
                    },
                    new LinksModel()
                    {
                        Id = 2,
                        Name = "Exercism",
                        Description = "Site avec des exos pour le dev",
                        Url = "https://exercism.com"
                    },
            };
        }
    }
}