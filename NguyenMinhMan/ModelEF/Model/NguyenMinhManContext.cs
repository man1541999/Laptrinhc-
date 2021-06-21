using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ModelEF.Model
{
    public partial class NguyenMinhManContext : DbContext
    {
        public NguyenMinhManContext()
            : base("name=NguyenMinhManContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.Password)
                .IsFixedLength();
        }
    }
}
