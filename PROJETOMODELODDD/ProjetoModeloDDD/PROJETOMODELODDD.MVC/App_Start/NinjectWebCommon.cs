using PROJETOMODELODDD.Aplicacao;
using PROJETOMODELODDD.Aplicacao.Interface;
using PROJETOMODELODDD.DOMINIO.Interfaces;
using PROJETOMODELODDD.DOMINIO.Interfaces.Repositorios;
using PROJETOMODELODDD.DOMINIO.Interfaces.Servicos;
using PROJETOMODELODDD.DOMINIO.Servicos;
using PROJETOMODELODDD.INFRA.DADDOS.Repositorio;
using PROJETOMODELODDD.INFRA.DADDOS;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(PROJETOMODELODDD.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(PROJETOMODELODDD.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace PROJETOMODELODDD.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            // APLICACAO
            kernel.Bind(typeof(IAppServicoBase<>)).To(typeof (AppServicoBase<>));
            kernel.Bind<IClienteAppServicoBase>().To<ClienteAppServicoBase>();
            kernel.Bind<IProdutoAppServicoBase>().To<ProdutoAppServicoBase>();

            //SERVICO
            kernel.Bind(typeof(IServicoBase<>)).To(typeof(ServicoBase<>));
            kernel.Bind<IClienteServico>().To<ClienteServico>();
            kernel.Bind<IProdutoServico>().To<ProdutoServico>();

            //REPOSITORIO
            kernel.Bind(typeof(IRepositorioBase<>)).To(typeof(RepositorioBase<>));
            kernel.Bind<IClienteRepositorio>().To<ClienteRepositorio>();
            kernel.Bind<IProdutoRepositorio>().To<ProdutoRepositorio>();

        }        
    }
}
