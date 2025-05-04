using CoffylabMVCProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffylabMVCProject.Context
{
    public class CoffylabContext : DbContext
    {

        //Web.config-> <connection string> yerine burada OnConfiguring() metodu olarak bağlantı yazılır.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-V7IDV6Q\\SQLEXPRESS01; Initial Catalog= Coffylab; Integrated Security= true; TrustServerCertificate= true"
                );
        }


        //SQL'e bunların birer tablo olacağını bildiriyoruz:
        public DbSet<Feature> Tbl_Feature { get; set; }
        public DbSet<Category> Tbl_Category { get; set; }
        public DbSet<Product> Tbl_Product { get; set; }
        public DbSet<Testimonial> Tbl_Testimonial { get; set; }
        public DbSet<Header> Tbl_Header { get; set; }
        public DbSet<Meet> Tbl_Meet { get; set; }
        public DbSet<SocialMedia> Tbl_SocialMedia { get; set; }
        public DbSet<Gallery> Tbl_Gallery { get; set; }
        public DbSet<Subscribe> Tbl_Subscribe { get; set; }
        public DbSet<Notification> Tbl_Notification { get; set; }
        public DbSet<Admin> Tbl_Admin { get; set; }
    }
}
