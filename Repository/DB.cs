using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Models.Users;

namespace Repository
{
    public class DB : DbContext
    {
        private static DB _instance { get; set; }
        public static DB GetContext()
        {
            if (_instance == null) _instance= new DB();
            return _instance;
        }
        public DB(){
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=DiplomDB;Trusted_Connection=True;");
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