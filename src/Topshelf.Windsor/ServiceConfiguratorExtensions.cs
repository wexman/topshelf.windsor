using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topshelf.ServiceConfigurators;

namespace Topshelf.Windsor
{
    public static class ServiceConfiguratorExtensions
    {
        public static ServiceConfigurator<T> ConstructUsingWindsorContainer<T>(this ServiceConfigurator<T> configurator)
        where T : class
        {
            configurator.ConstructUsing(serviceFactory => WindsorHostBuilderConfigurator.WindsorContainer.Resolve<T>());
            return configurator;
        }
    }
}
