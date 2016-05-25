using System;
using Microsoft.AspNetCore.Mvc;

namespace Folke.Mvc.Extensions
{
    public class CreatedResult<T> : CreatedResult, IHttpActionResult<T>
    {
        public CreatedResult(Uri location, T value):base(location, value)
        {
            
        }
    }
}