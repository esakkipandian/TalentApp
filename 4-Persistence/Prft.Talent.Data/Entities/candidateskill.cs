namespace Prft.Talent.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("candidateskill")]
    public partial class candidateskill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PK { get; set; }

        public int CandidateId { get; set; }

        public int SkillId { get; set; }

        public int Rating { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SinceLastUsed { get; set; }

        [Column(TypeName = "bit")]
        public bool? IsPrimary { get; set; }

        [Column(TypeName = "bit")]
        public bool IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public virtual candidate candidate { get; set; }

        public virtual skill skill { get; set; }
    }
}
