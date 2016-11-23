using Microsoft.AspNetCore.Mvc;

namespace Folke.Mvc.Extensions
{
    public class HttpServiceUnavailableObjectResult<T> : ObjectResult, IHttpActionResult<T>
    {
        public HttpServiceUnavailableObjectResult(object error): base(error)
        {
            StatusCode = 503;
        }
    }
}
