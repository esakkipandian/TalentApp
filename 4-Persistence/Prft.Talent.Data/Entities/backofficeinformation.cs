namespace Prft.Talent.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("backofficeinformation")]
    public partial class backofficeinformation
    {
        public decimal? CurrentCTC { get; set; }

        public decimal? VariablePay { get; set; }

        public DateTime? LastIncrementedDate { get; set; }

        public bool? Form16Verified { get; set; }

        [StringLength(255)]
        public string ProjectDetails { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PK { get; set; }

        public int? CandidateId { get; set; }

        public virtual candidate candidate { get; set; }
    }
}
