namespace Prft.Talent.Data.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TalentContext : DbContext
    {
        public TalentContext()
            : base("name=TalentContext")
        {
        }

        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<test> tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<test>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
