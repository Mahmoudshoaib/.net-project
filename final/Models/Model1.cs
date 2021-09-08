using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace final.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<catalog> catalog { get; set; }
        public virtual DbSet<posts> posts { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<catalog>()
                .HasMany(e => e.posts)
                .WithOptional(e => e.catalog)
                .HasForeignKey(e => e.cat_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.posts)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.user_id);
        }
    }
}
