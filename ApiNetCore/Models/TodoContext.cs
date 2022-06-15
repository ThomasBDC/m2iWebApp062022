using Microsoft.EntityFrameworkCore;
using ApiNetCore.Models;

namespace ApiNetCore.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<UserModel> UserModel { get; set; }
    }
}
