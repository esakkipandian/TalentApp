namespace Prft.Talent.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("college")]
    public partial class college
    {
        [Key]
        public int PK { get; set; }

        [StringLength(5)]
        public string Code { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Column(TypeName = "bit")]
        public bool? IsActive { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(100)]
        public string LastUpdatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public virtual candidateeducation candidateeducation { get; set; }
    }
}
