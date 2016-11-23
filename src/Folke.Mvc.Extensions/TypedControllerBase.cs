using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Folke.Mvc.Extensions
{
    public class TypedControllerBase : Controller
    {
        public HttpOkObjectResult<T> Ok<T>(T value)
        {
            IDisposable disposable = value as IDisposable;
            if (disposable != null)
                Response.RegisterForDispose(disposable);
            return new HttpOkObjectResult<T>(value);
        }

        public HttpNotFoundResult<T> NotFound<T>()
        {
            return new HttpNotFoundResult<T>();
        }

        public HttpInternalServerErrorObjectResult<T> InternalServerError<T>(object error)
        {
            return new HttpInternalServerErrorObjectResult<T>(error);
        }

        public HttpServiceUnavailableObjectResult<T> ServiceUnavailable<T>(object error)
        {
            return new HttpServiceUnavailableObjectResult<T>(error);
        }

        public HttpUnauthorizedResult<T> Unauthorized<T>()
        {
            return new HttpUnauthorizedResult<T>();
        }

        public HttpBadRequestObjectResult<T> BadRequest<T>(object error)
        {
            return new HttpBadRequestObjectResult<T>(error);
        }

        public HttpBadRequestObjectResult<T> BadRequest<T>(ModelStateDictionary error)
        {
            return new HttpBadRequestObjectResult<T>(error);
        }

        public CreatedResult<T> Created<T, TKey>(string routeName, TKey id, T content)
        {
            return new CreatedResult<T>(new Uri(Url.Link(routeName,new { id })), content);
        }
    }
}
