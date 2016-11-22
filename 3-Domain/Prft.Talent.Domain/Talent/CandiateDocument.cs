namespace Prft.Talent.Domain.Talent
{
    public class CandidateDocument
    {
        public int PK { get; set; }
        public int CandidateId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public byte[] DocumentContent { get; set; }
    }
}