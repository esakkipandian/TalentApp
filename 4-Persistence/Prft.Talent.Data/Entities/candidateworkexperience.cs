namespace Prft.Talent.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("candidateworkexperience")]
    public partial class candidateworkexperience
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PK { get; set; }

        public int CandidateId { get; set; }

        [StringLength(300)]
        public string OrganizationName { get; set; }

        [StringLength(200)]
        public string Designation { get; set; }

        [StringLength(1000)]
        public string Roles { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(200)]
        public string LeavingReason { get; set; }

        [Column(TypeName = "bit")]
        public bool? IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public virtual candidate candidate { get; set; }
    }
}
