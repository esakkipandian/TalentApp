namespace Prft.Talent.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("candidatefeedback")]
    public partial class candidatefeedback
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public candidatefeedback()
        {
            evaluations = new HashSet<evaluation>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PK { get; set; }

        public int CandidateId { get; set; }

        public DateTime? InterviewDate { get; set; }

        public int? InterviewerId { get; set; }

        public DateTime DateOfInterview { get; set; }

        [StringLength(100)]
        public string ApppliedPosition { get; set; }

        public virtual candidate candidate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<evaluation> evaluations { get; set; }
    }
}
