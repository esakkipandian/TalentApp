namespace Prft.Talent.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("candidateaddress")]
    public partial class candidateaddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PK { get; set; }

        public int CandidateId { get; set; }

        public int AddressTypeId { get; set; }

        [StringLength(150)]
        public string AddressLine1 { get; set; }

        [StringLength(150)]
        public string AddressLine2 { get; set; }

        [StringLength(150)]
        public string City { get; set; }

        public int? StateId { get; set; }

        public int? CountryId { get; set; }

        [Column(TypeName = "bit")]
        public bool IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public virtual addresstype addresstype { get; set; }

        public virtual candidate candidate { get; set; }

        public virtual country country { get; set; }

        public virtual state state { get; set; }
    }
}
