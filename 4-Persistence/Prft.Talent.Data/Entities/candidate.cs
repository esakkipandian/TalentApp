namespace Prft.Talent.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("candidate")]
    public partial class candidate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public candidate()
        {
            backofficeinformations = new HashSet<backofficeinformation>();
            candidatefeedbacks = new HashSet<candidatefeedback>();
            candidatedocuments = new HashSet<candidatedocument>();
            candidateeducations = new HashSet<candidateeducation>();
            candidateskills = new HashSet<candidateskill>();
            candidateworkexperiences = new HashSet<candidateworkexperience>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PK { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        [StringLength(100)]
        public string FatherName { get; set; }

        [StringLength(3000)]
        public string PermanentAddress { get; set; }

        [StringLength(3000)]
        public string CommunicationAddress { get; set; }

        [StringLength(45)]
        public string Nationality { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(15)]
        public string Mobile { get; set; }

        [StringLength(15)]
        public string AlternateContact { get; set; }

        [Column(TypeName = "bit")]
        public bool? IsExperienced { get; set; }

        [Column(TypeName = "bit")]
        public bool IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<backofficeinformation> backofficeinformations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<candidatefeedback> candidatefeedbacks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<candidatedocument> candidatedocuments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<candidateeducation> candidateeducations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<candidateskill> candidateskills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<candidateworkexperience> candidateworkexperiences { get; set; }
    }
}
