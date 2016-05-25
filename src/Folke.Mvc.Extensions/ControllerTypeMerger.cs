using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.DependencyInjection;

namespace Folke.Mvc.Extensions
{
    public class ControllerTypeMerger : IControllerTypeProvider
    {
        private readonly IServiceProvider serviceLocator;

        public ControllerTypeMerger(IServiceProvider serviceLocator)
        {
            this.serviceLocator = serviceLocator;
        }

        public IEnumerable<TypeInfo> ControllerTypes
        {
            get
            {
                var providers = serviceLocator.GetServices<IControllerTypeProvider>();
                foreach (var provider in providers)
                {
                    if (provider is ControllerTypeMerger) continue;

                    foreach (var typeInfo in provider.ControllerTypes)
                    {
                        yield return typeInfo;
                    }
                }
            }
        }
    }
}
