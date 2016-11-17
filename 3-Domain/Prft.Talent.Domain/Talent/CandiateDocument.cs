using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prft.Talent.Domain.Talent
{
    public class CandiateDocument
    {
        public int PK { get; set; }
        public int CandidateId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public byte[] DocumentContent { get; set; }
        public bool IsActive { get; set; }
    }
}