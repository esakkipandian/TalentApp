using System;

namespace Prft.Talent.Domain.Talent
{
    public class EmployerDetails
    {
        public int PK { get; set; }

        public int CandidateId { get; set; }

        public string OrganizationName { get; set; }

        public string Designation { get; set; }

        public string Roles { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string LeavingReason { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }
    }
}