namespace Runners.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RunnersContext : DbContext
    {
        public RunnersContext()
            : base("name=RunnersContext")
        {
            Database.SetInitializer(new RunnersInitializer());
        }

        public virtual DbSet<Pace> Pace { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
