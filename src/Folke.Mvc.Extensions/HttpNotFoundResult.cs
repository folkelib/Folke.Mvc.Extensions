using Microsoft.AspNet.Mvc;

namespace Folke.Mvc.Extensions
{
    public class HttpNotFoundResult<T> : HttpNotFoundResult, IHttpActionResult<T>
    {
    }
}
