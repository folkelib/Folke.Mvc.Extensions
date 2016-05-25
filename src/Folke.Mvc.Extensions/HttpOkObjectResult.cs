using Microsoft.AspNetCore.Mvc;

namespace Folke.Mvc.Extensions
{
    public class HttpOkObjectResult<T> : OkObjectResult, IHttpActionResult<T>
    {
        public HttpOkObjectResult(T value) : base(value)
        {
        }
    }
}
