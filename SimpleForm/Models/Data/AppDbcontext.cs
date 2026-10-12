using Microsoft.EntityFrameworkCore;

namespace SimpleForm.Models.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }      
    
    }
}
