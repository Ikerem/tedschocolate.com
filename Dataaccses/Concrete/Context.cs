using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccses.Concrete
{
    public class Context:IdentityDbContext<CeoUser,CeoRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=KEREMGENCPC\\SQLEXPRESS; initial catalog = tedschocolate; integrated security = true");

        }
        public DbSet<Homepage> homepages { get; set; }
        public DbSet<OurChocolates> OurChocolates { get; set; }
        public DbSet<SendMessage> SendMessages { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<ChocolateoptionsList> ChocolateoptionsLists { get; set; }
        public DbSet<ColorCategory> ColorCategories { get; set; }
    }
}
