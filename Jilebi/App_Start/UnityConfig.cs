using Jilebi.Business;
using Jilebi.Repository.Infrastructure.Contract;
using MVCTutorial.Repository.Infrastructure;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace Jilebi
{
    public static class UnityConfig
    { 
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<IEmployee, Employee>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();

         //   container.RegisterType<Employee>(new InjectionConstructor(0));
        }
    }
}