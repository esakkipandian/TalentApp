namespace Prft.Talent.Domain.Talent
{
    public class Document
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public byte[] DocumentContent { get; set; }
        public bool IsActive { get; set; }
    }
}