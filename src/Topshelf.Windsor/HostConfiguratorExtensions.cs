using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topshelf.HostConfigurators;

namespace Topshelf.Windsor
{
    public static class HostConfiguratorExtensions
    {
        public static HostConfigurator UseWindsorContainer(this HostConfigurator configurator, IWindsorContainer windsorContainer)
        {
            configurator.AddConfigurator(new WindsorHostBuilderConfigurator(windsorContainer));
            return configurator;
        }
    }
}
