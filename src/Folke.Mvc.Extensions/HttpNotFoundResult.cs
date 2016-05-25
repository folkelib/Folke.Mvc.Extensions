using Microsoft.AspNetCore.Mvc;

namespace Folke.Mvc.Extensions
{
    public class HttpNotFoundResult<T> : NotFoundResult, IHttpActionResult<T>
    {
    }
}
