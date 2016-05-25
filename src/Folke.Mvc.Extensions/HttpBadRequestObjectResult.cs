using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Folke.Mvc.Extensions
{
    public class HttpBadRequestObjectResult<T> : BadRequestObjectResult, IHttpActionResult<T>
    {
        public HttpBadRequestObjectResult(object error) : base(error)
        {
        }

        public HttpBadRequestObjectResult(ModelStateDictionary error) : base(error)
        {
        }
    }
}