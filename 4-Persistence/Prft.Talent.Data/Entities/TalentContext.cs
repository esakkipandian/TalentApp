namespace Prft.Talent.Data.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class TalentContext : DbContext
    {
        public TalentContext()
            : base("name=TalentContext")
        {
        }

        public virtual DbSet<employee> employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<employee>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
