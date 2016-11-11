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

        public virtual DbSet<addresstype> addresstypes { get; set; }
        public virtual DbSet<candidate> candidates { get; set; }
        public virtual DbSet<candidateaddress> candidateaddresses { get; set; }
        public virtual DbSet<candidateeducation> candidateeducations { get; set; }
        public virtual DbSet<candidateskill> candidateskills { get; set; }
        public virtual DbSet<candidateworkexperience> candidateworkexperiences { get; set; }
        public virtual DbSet<college> colleges { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<skill> skills { get; set; }
        public virtual DbSet<state> states { get; set; }
        public virtual DbSet<university> universities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<addresstype>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<addresstype>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<addresstype>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<addresstype>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<addresstype>()
                .HasMany(e => e.candidateaddresses)
                .WithRequired(e => e.addresstype)
                .HasForeignKey(e => e.AddressTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<candidate>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<candidate>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<candidate>()
                .Property(e => e.FatherName)
                .IsUnicode(false);

            modelBuilder.Entity<candidate>()
                .Property(e => e.MotherName)
                .IsUnicode(false);

            modelBuilder.Entity<candidate>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<candidate>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<candidate>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<candidate>()
                .Property(e => e.AlternateContact)
                .IsUnicode(false);

            modelBuilder.Entity<candidate>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<candidate>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<candidate>()
                .HasMany(e => e.candidateskills)
                .WithRequired(e => e.candidate)
                .HasForeignKey(e => e.CandidateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<candidate>()
                .HasMany(e => e.candidateworkexperiences)
                .WithRequired(e => e.candidate)
                .HasForeignKey(e => e.CandidateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<candidate>()
                .HasMany(e => e.candidateaddresses)
                .WithRequired(e => e.candidate)
                .HasForeignKey(e => e.CandidateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<candidate>()
                .HasMany(e => e.candidateeducations)
                .WithRequired(e => e.candidate)
                .HasForeignKey(e => e.CandidateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<candidateaddress>()
                .Property(e => e.AddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<candidateaddress>()
                .Property(e => e.AddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<candidateaddress>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<candidateaddress>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<candidateaddress>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<candidateeducation>()
                .Property(e => e.DegreeName)
                .IsUnicode(false);

            modelBuilder.Entity<candidateeducation>()
                .Property(e => e.Specialization)
                .IsUnicode(false);

            modelBuilder.Entity<candidateeducation>()
                .Property(e => e.College)
                .IsUnicode(false);

            modelBuilder.Entity<candidateeducation>()
                .Property(e => e.University)
                .IsUnicode(false);

            modelBuilder.Entity<candidateeducation>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<candidateeducation>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<candidateskill>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<candidateskill>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<candidateworkexperience>()
                .Property(e => e.OrganizationName)
                .IsUnicode(false);

            modelBuilder.Entity<candidateworkexperience>()
                .Property(e => e.Designation)
                .IsUnicode(false);

            modelBuilder.Entity<candidateworkexperience>()
                .Property(e => e.Roles)
                .IsUnicode(false);

            modelBuilder.Entity<candidateworkexperience>()
                .Property(e => e.LeavingReason)
                .IsUnicode(false);

            modelBuilder.Entity<candidateworkexperience>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<candidateworkexperience>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<college>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<college>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<college>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<college>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<college>()
                .HasOptional(e => e.candidateeducation)
                .WithRequired(e => e.college1);

            modelBuilder.Entity<country>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<country>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<country>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<country>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<country>()
                .HasMany(e => e.candidateaddresses)
                .WithOptional(e => e.country)
                .HasForeignKey(e => e.CountryId);

            modelBuilder.Entity<skill>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<skill>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<skill>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<skill>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<skill>()
                .HasMany(e => e.candidateskills)
                .WithRequired(e => e.skill)
                .HasForeignKey(e => e.SkillId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<state>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<state>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<state>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<state>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<state>()
                .HasMany(e => e.candidateaddresses)
                .WithOptional(e => e.state)
                .HasForeignKey(e => e.StateId);

            modelBuilder.Entity<university>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .HasMany(e => e.candidateeducations)
                .WithOptional(e => e.university1)
                .HasForeignKey(e => e.UniversityId);
        }
    }
}
