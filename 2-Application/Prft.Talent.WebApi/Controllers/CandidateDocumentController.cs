﻿using Prft.Talent.Domain.Talent;
using Prft.Talent.Services.Abstract;
using Prft.Talent.Services.Api;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Web.Http;

namespace Prft.Talent.WebApi.Controllers
{
    public class CandidateDocumentController : ApiController
    {
        private readonly ICandidateDocumentService _candidateDocumentService;

        public CandidateDocumentController(ICandidateDocumentService candidateDocumentService)
        {
            _candidateDocumentService = candidateDocumentService;
        }

        // GET api/<controller>
        public async Task<CandidateDocumentResponse> Get(int id)
        {
            var fileDocument = await _candidateDocumentService.GetCandidateDocumentsAsync(id);
            return fileDocument;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post(CandidateDocument candiateDocument)
        {
            //, HttpPostedFileBase postedFile
            var file = System.Web.HttpContext.Current.Request.Files[0];
            byte[] bytes;

            using (BinaryReader br = new BinaryReader(file.InputStream))
            {
                bytes = br.ReadBytes(file.ContentLength);
            }
            candiateDocument.DocumentContent = bytes;
            candiateDocument.DocumentName = file.FileName;
            candiateDocument.DocumentType = file.ContentType;
            _candidateDocumentService.AddDocumentAsync(candiateDocument);

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {

        }
    }
}