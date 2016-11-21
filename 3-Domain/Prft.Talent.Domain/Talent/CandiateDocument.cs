namespace Prft.Talent.Domain.Talent
{
    public class CandiateDocument
    {
        public int CandidateId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public byte[] DocumentContent { get; set; }
        //public bool IsActive { get; set; }
        //public DateTime? CreatedDate { get; set; }
        //public string CreatedBy { get; set; }
        //public DateTime? ModifiedDate { get; set; }
        //public string ModifiedBy { get; set; }        
    }
}