namespace Prft.Talent.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("interviewschedule")]
    public partial class interviewschedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PK { get; set; }

        public int CandidateId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ScheduleDate { get; set; }

        public TimeSpan? ScheduleTime { get; set; }

        public int InterviewerId { get; set; }

        public int LevelId { get; set; }

        [Column(TypeName = "bit")]
        public bool IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public virtual candidate candidate { get; set; }

        public virtual interviewer interviewer { get; set; }

        public virtual interviewlevel interviewlevel { get; set; }
    }
}
