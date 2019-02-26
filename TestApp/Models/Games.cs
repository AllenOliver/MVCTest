namespace TestApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Games : DbContext
    {
        public Games()
            : base("name=Games")
        {
        }

        public virtual DbSet<Game> Game { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .Property(e => e.GameName)
                .IsUnicode(false);
        }
    }
}