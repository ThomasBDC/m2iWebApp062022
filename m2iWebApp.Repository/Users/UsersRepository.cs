using m2iWebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace m2iWebApp.Repository.Users
{
    public static class UsersRepository
    {
        public static List<UserModel> getAllUsers()
        {
            return new List<UserModel>()
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
                        Id = 2,
                        Name = "HADJIOUAL",
                        Surname = "Leila",
                        Mail = "HADJIOUALLeila@yopmail.com"
                    },new UserModel()
                    {
                        Id = 3,
                        Name = "NIBBIO",
                        Surname = "Julien",
                        Mail = "nibbioJulien@yopmail.com"
                    },
            };
        }
    }
}
