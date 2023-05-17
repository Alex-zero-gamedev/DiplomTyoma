using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Models.Users;

namespace Repository
{
    public class AppContext : DbContext
    {
        private static AppContext _instance { get; set; }
        public static AppContext GetContext()
        {
            if (_instance == null) _instance= new AppContext();
            return _instance;
        }
        public AppContext(){
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=TutorialDB;Username=postgres;Password=8904");
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<College> Colleges { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<Special> Specials { get; set; }
        public DbSet<TutorialProgram> TutorialPrograms { get; set; }
    }
}