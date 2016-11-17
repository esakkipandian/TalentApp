using Prft.Talent.Services.Abstract;
using System.Web.Http;

namespace Prft.Talent.WebApi.Controllers
{
    public class FileuploadController : ApiController
    {
        private readonly IFileuploadService _fileuploadService;

        public FileuploadController(IFileuploadService fileuploadService)
        {
            _fileuploadService = fileuploadService;
        }

        // GET api/<controller>
        //public async Task<FileDocumentResponse> Get()
        //{
        //    var fileDocument = await _fileuploadService.GetFileDocumentAsync();
        //    return fileDocument;
        //}

        // GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]byte[] value)
        {
            var file = System.Web.HttpContext.Current.Request.Files[0];
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