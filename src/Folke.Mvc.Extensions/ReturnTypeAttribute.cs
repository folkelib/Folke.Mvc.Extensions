using System;

namespace Folke.Mvc.Extensions
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class ReturnTypeAttribute : Attribute
    {
        public Type ReturnType { get; set; }

        public ReturnTypeAttribute(Type returnType)
        {
            ReturnType = returnType;
        }
    }
}
