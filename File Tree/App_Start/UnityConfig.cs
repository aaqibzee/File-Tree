using System.Web.Mvc;
using BusinessLogic.Implementations;
using BusinessLogic.Implementations.Clients;
using BusinessLogic.Interfaces;
using Unity;
using Unity.Mvc5;

namespace File_Tree
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IDirectoryClient, DirectoryClient>();
            container.RegisterType<IDirectoryManager, DirectoryManager>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}