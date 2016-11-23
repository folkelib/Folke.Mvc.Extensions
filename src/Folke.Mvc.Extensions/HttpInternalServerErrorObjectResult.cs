using Microsoft.AspNetCore.Mvc;

namespace Folke.Mvc.Extensions
{
    public class HttpInternalServerErrorObjectResult<T> : ObjectResult, IHttpActionResult<T>
    {
        public HttpInternalServerErrorObjectResult(object error): base(error)
        {
            StatusCode = 500;
        }
    }
}
