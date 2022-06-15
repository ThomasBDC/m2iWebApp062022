using System;

namespace ApiNetCore.Models
{
    public class UserModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateNaissance { get; set; }
    }
}
