using Microsoft.EntityFrameworkCore;
using UsersRole.Model;

namespace UsersRole.DAL
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }  
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Street> Streets { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    RoleId = 1,
                    RoleName="Herbici"
                },
                new Role
                {
                    RoleId=2,
                    RoleName="Tornaci"
                }
                );
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permission>().HasData(
                new Permission
                {
                    Id = 1,
                    Name = "add",
                    Key = "add"
                },
                  new Permission
                  {
                      Id = 2,
                      Name = "hesabat",
                      Key = "report"
                  },
                    new Permission
                    {
                        Id = 3,
                        Name = "view",
                        Key = "view"
                    }
                );
        }
    }
}
