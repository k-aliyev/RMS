using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using MySql.Data.MySqlClient;


namespace DataAccess
{

    public class Db : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<UserResource> UserResources { get; set; }

        public Db(DbContextOptions options) : base(options)
        {

        }
    }

}
