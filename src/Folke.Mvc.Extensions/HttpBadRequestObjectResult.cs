using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.ModelBinding;

namespace Folke.Mvc.Extensions
{
    public class HttpBadRequestObjectResult<T> : BadRequestObjectResult, IHttpActionResult<T>
    {
        public HttpBadRequestObjectResult(object error) : base(error)
        {
        }

        public HttpBadRequestObjectResult(ModelState error) : base(error)
        {
        }
    }
}