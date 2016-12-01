namespace Prft.Talent.Data.Entities
{
    using System.Data.Entity;
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public partial class TalentContext : DbContext
    {
        public TalentContext()
            : base("name=TalentContext")
        {
        }

        public virtual DbSet<backofficeinformation> backofficeinformations { get; set; }
        public virtual DbSet<candidate> candidates { get; set; }
        public virtual DbSet<candidatedocument> candidatedocuments { get; set; }
        public virtual DbSet<candidateeducation> candidateeducations { get; set; }
        public virtual DbSet<candidatefeedback> candidatefeedbacks { get; set; }
        public virtual DbSet<candidateskill> candidateskills { get; set; }
        public virtual DbSet<candidateworkexperience> candidateworkexperiences { get; set; }
        public virtual DbSet<college> colleges { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<evaluation> evaluations { get; set; }
        public virtual DbSet<skill> skills { get; set; }
        public virtual DbSet<skillevaluation> skillevaluations { get; set; }
        public virtual DbSet<state> states { get; set; }
        public virtual DbSet<university> universities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<backofficeinformation>()
                .Property(e => e.ProjectDetails)
                .IsUnicode(false);

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
                .Property(e => e.PermanentAddress)
                .IsUnicode(false);

            modelBuilder.Entity<candidate>()
                .Property(e => e.CommunicationAddress)
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
                .HasMany(e => e.backofficeinformations)
                .WithOptional(e => e.candidate)
                .HasForeignKey(e => e.CandidateId);

            modelBuilder.Entity<candidate>()
                .HasMany(e => e.candidatefeedbacks)
                .WithRequired(e => e.candidate)
                .HasForeignKey(e => e.CandidateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<candidate>()
                .HasMany(e => e.candidatedocuments)
                .WithRequired(e => e.candidate)
                .HasForeignKey(e => e.CandidateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<candidate>()
                .HasMany(e => e.candidateeducations)
                .WithRequired(e => e.candidate)
                .HasForeignKey(e => e.CandidateId)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<candidatedocument>()
                .Property(e => e.DocumentName)
                .IsUnicode(false);

            modelBuilder.Entity<candidatedocument>()
                .Property(e => e.DocumentType)
                .IsUnicode(false);

            modelBuilder.Entity<candidatedocument>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<candidatedocument>()
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

            modelBuilder.Entity<candidatefeedback>()
                .Property(e => e.ApppliedPosition)
                .IsUnicode(false);

            modelBuilder.Entity<candidatefeedback>()
                .HasMany(e => e.evaluations)
                .WithRequired(e => e.candidatefeedback)
                .HasForeignKey(e => e.CandidateFeedbackId)
                .WillCascadeOnDelete(false);

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
                .Property(e => e.ContactPerson)
                .IsUnicode(false);

            modelBuilder.Entity<candidateworkexperience>()
                .Property(e => e.ContactNumber)
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
                .HasMany(e => e.candidateeducations)
                .WithOptional(e => e.college1)
                .HasForeignKey(e => e.CollegeId);

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

            modelBuilder.Entity<evaluation>()
                .Property(e => e.EvaluationComments)
                .IsUnicode(false);

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

            modelBuilder.Entity<skillevaluation>()
                .Property(e => e.EvaluationSkillName)
                .IsUnicode(false);

            modelBuilder.Entity<skillevaluation>()
                .Property(e => e.EvaluationSkillDescription)
                .IsUnicode(false);

            modelBuilder.Entity<skillevaluation>()
                .HasMany(e => e.evaluations)
                .WithRequired(e => e.skillevaluation)
                .HasForeignKey(e => e.EvaluationSkillId)
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
