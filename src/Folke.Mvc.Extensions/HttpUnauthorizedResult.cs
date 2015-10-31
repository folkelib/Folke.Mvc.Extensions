using Microsoft.AspNet.Mvc;

namespace Folke.Mvc.Extensions
{
    public class HttpUnauthorizedResult<T> : HttpUnauthorizedResult, IHttpActionResult<T>
    {
    }
}