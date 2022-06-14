using System;
using System.Collections.Generic;

namespace RepoStandard
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
    }
    public static class UsersRepositoryStandard
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
        }
    }
