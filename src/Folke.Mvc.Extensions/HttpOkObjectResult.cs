using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Folke.Mvc.Extensions
{
    public class HttpOkObjectResult<T> : HttpOkObjectResult, IHttpActionResult<T>
    {
        public HttpOkObjectResult(T value) : base(value)
        {
        }
    }
}
