using IdentityChatEmailNight.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityChatEmailNight.Context
{
    public class EmailContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GI3R06F\\SQLEXPRESS; initial Catalog= EmailChatNightDb; integrated security=true;trust server certificate=true");
            // projeyi 6'nın üstünde kullanıyorsak trust server certificate true yapmalıyız

        }
        public DbSet<Message> Messages { get; set; }
    }
}
