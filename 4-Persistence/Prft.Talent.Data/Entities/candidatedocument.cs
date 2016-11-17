namespace Prft.Talent.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("candidatedocument")]
    public partial class candidatedocument
    {
        [Key]
        public int PK { get; set; }

        public int CandidateId { get; set; }

        [Required]
        [StringLength(100)]
        public string DocumentName { get; set; }

        [Required]
        [StringLength(45)]
        public string DocumentType { get; set; }

        [Column(TypeName = "blob")]
        [Required]
        public byte[] DocumentContent { get; set; }

        [Column(TypeName = "bit")]
        public bool IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public virtual candidate candidate { get; set; }
    }
}
