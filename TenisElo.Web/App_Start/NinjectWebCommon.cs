using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using Ninject.Extensions.Conventions;
using System;
using System.Linq;
using System.Web;
using TenisElo.Web.App_Start;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(NinjectWebCommon), "Stop")]
namespace TenisElo.Web.App_Start
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            RegisterServices(kernel);

         
            return kernel;
        }
        private static void RegisterServices(IKernel kernel)
        {
            //kernel.Bind(scanner => scanner.FromAssembliesInPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
            kernel.Bind(scanner => scanner.From("TenisElo.Web", "TenisElo.Data", "TenisElo.Repository", "TenisElo.Service")
                .Select(IsServiceType)
                .BindDefaultInterface()
                .Configure(binding => binding.InSingletonScope())
            );

        }

        private static bool IsServiceType(Type type)
        {
            return type.IsClass && type.GetInterfaces().Any(intface => intface.Name == "I" + type.Name);
        }

    }
}