using Microsoft.AspNetCore.Mvc;

namespace Folke.Mvc.Extensions
{
    public class HttpUnauthorizedResult<T> : UnauthorizedResult, IHttpActionResult<T>
    {
    }
}