using Core_Proje_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje_Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CTQ3847\\" +
                "SQLEXPRESS;database=CoreProjeDB2;TrustServerCertificate=True\r\n;integrated security = true");
        }
        public DbSet<Category> Categories {  get; set; }
    }
}
