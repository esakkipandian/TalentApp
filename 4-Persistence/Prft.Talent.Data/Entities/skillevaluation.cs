namespace Prft.Talent.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("skillevaluation")]
    public partial class skillevaluation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public skillevaluation()
        {
            evaluations = new HashSet<evaluation>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PK { get; set; }

        [StringLength(200)]
        public string EvaluationSkillName { get; set; }

        [StringLength(500)]
        public string EvaluationSkillDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<evaluation> evaluations { get; set; }
    }
}
