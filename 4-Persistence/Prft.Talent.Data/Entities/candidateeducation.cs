namespace Prft.Talent.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("candidateeducation")]
    public partial class candidateeducation
    {
        [Key]
        public int PK { get; set; }

        public int CandidateId { get; set; }

        [StringLength(100)]
        public string DegreeName { get; set; }

        [StringLength(200)]
        public string Specialization { get; set; }

        public int? CollegeId { get; set; }

        [StringLength(200)]
        public string College { get; set; }

        public int? UniversityId { get; set; }

        [StringLength(200)]
        public string University { get; set; }

        [Column(TypeName = "date")]
        public DateTime? YearOfPassing { get; set; }

        public decimal? Percentage { get; set; }

        [Column(TypeName = "bit")]
        public bool IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public virtual candidate candidate { get; set; }

        public virtual college college1 { get; set; }

        public virtual university university1 { get; set; }
        public int Qualification { get; set; }
        public string CourseType { get; set; }
    }
}
