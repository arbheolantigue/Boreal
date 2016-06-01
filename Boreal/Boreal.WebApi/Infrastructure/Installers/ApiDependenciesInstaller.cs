using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BorealPersistence;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Boreal.WebApi.Infrastructure.Installers
{
    public class ApiDependenciesInstaller: IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromAssemblyContaining<BorealContext>()
                    .BasedOn(typeof (IRepository<,>))
                    .WithServiceAllInterfaces()
                );
        }
    }
}