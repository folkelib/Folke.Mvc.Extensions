using System;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.ModelBinding;

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
            return new CreatedResult<T>(new Uri(this.Url.Link(routeName,new { id })), content);
        }
    }
}
