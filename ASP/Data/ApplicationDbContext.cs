using ASP.Models;
using Microsoft.EntityFrameworkCore;
namespace ASP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Taskk> Taskks { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Reminder> Reminders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Taskk sınıfının Id'si birincil anahtar olarak ayarlandı
            modelBuilder.Entity<Taskk>()
                .HasKey(t => t.Id);

            // User sınıfının Id'si birincil anahtar olarak ayarlandı
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserID);

            // Taskk ve User arasında ilişkiyi belirtiyoruz
            modelBuilder.Entity<Taskk>()
                .HasOne(t => t.User)  // Her Taskk bir User'a ait
                .WithMany(u => u.Tasks)  // Bir User birçok Taskk'ya sahip olabilir
                .HasForeignKey(t => t.UserId);  // UserId, foreign key olarak kullanılacak

            // Event ve Reminder modellerinin de benzer ilişkilerini kurabilirsiniz
            modelBuilder.Entity<Event>()
                .HasKey(e => e.EventID);

            modelBuilder.Entity<Reminder>()
                .HasKey(r => r.ReminderID);
        }
    }
}