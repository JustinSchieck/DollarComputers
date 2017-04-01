namespace DollarComputers
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ComputerStoreContext : DbContext
    {
        public ComputerStoreContext()
            : base("name=ComputerStoreContextConnection")
        {
        }

        public virtual DbSet<DollarComputer> DollarComputers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DollarComputer>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
