using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topshelf.Builders;
using Topshelf.Configurators;
using Topshelf.HostConfigurators;

namespace Topshelf.Windsor
{
    public class WindsorHostBuilderConfigurator : HostBuilderConfigurator
    {
        private static IWindsorContainer windsorContainer;

        public WindsorHostBuilderConfigurator(IWindsorContainer windsorContainer)
        {
            if (windsorContainer == null)
            {
                throw new ArgumentNullException("windsorContainer");
            }
            WindsorHostBuilderConfigurator.windsorContainer = windsorContainer;
        }
        public static IWindsorContainer WindsorContainer
        {
            get { return windsorContainer; }
        }
        public HostBuilder Configure(HostBuilder builder)
        {
            return builder;
        }
        public IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }
    }
}
