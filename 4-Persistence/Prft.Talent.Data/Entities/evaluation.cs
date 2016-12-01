namespace Prft.Talent.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("evaluation")]
    public partial class evaluation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PK { get; set; }

        public int CandidateFeedbackId { get; set; }

        public int EvaluationSkillId { get; set; }

        public int? Rating { get; set; }

        [StringLength(500)]
        public string EvaluationComments { get; set; }

        public virtual candidatefeedback candidatefeedback { get; set; }

        public virtual skillevaluation skillevaluation { get; set; }
    }
}
