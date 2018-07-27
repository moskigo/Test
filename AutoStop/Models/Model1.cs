namespace AutoStop.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Analog> Analogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Part>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Part>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
