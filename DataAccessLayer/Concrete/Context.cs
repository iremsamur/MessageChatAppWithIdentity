using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
            optionsBuilder.UseSqlServer("server=LAPTOP-ISO96UVH\\SQLEXPRESS;database=MessageAppDb;integrated security=true;");
         

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
          

            modelBuilder.Entity<Message>()
                .HasOne(x => x.SenderUser)
                .WithMany(y => y.UserSender)
                .HasForeignKey(z => z.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);
          
            modelBuilder.Entity<Message>()
                .HasOne(x => x.ReceiverUser)
                .WithMany(y => y.UserReceiver)
                .HasForeignKey(z => z.ReceiverID)
                .OnDelete(DeleteBehavior.ClientSetNull);
            base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Friendlist>()
           .HasOne(x => x.AccountOwnerPerson)
           .WithMany(y => y.AccountOwner)
           .HasForeignKey(z => z.AccountOwnerPersonID)
           .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Friendlist>()
                .HasOne(x => x.FriendPerson)
                .WithMany(y => y.Friend)
                .HasForeignKey(z => z.FriendPersonID)
                .OnDelete(DeleteBehavior.ClientSetNull);
            base.OnModelCreating(modelBuilder);





        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Friendlist> Friendlists { get; set; }
    }
}
