using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Web.Something
{
    public class SomeController
    {
        [HttpGet]
        public Task<HttpResponseMessage> Export(Guid id)
        {
            // Build the file name.
            var fileDownloadName = "TODO: Build file name";

            // Build the file contents.
            var fileContents = "TODO: Build file contents here";

            // Set the headers to indicate we are returning a file.
            var downloadContent = new StringContent(fileContents);
            downloadContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            downloadContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            {
                FileName = fileDownloadName
            };

            // Respond with the file.
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = downloadContent
            };
        }
    }
}