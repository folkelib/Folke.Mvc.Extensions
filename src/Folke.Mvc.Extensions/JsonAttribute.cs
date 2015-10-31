using System;

namespace Folke.Mvc.Extensions
{
    public enum JsonUsage
    {
        Data,
        Service
    }

    public class JsonAttribute : Attribute
    {
        public JsonUsage Usage { get; set; }
        public bool Observable { get; set; }
    }
}
