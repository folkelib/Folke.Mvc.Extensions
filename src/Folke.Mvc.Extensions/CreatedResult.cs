using System;
using Microsoft.AspNet.Mvc;

namespace Folke.Mvc.Extensions
{
    public class CreatedResult<T> : CreatedResult, IHttpActionResult<T>
    {
        public CreatedResult(Uri location, T value):base(location, value)
        {
            
        }
    }
}