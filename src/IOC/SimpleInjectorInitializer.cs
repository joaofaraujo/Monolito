using System.Reflection;
using System.Web.Mvc;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;

namespace IOC
{
    public class SimpleInjectorInitializer
    {
        public void Initialize()
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

            SimpleInjectorInitializerFactory.SetContainer(container);

        }

        private void InitializeContainer(Container container)
        {
            BootStrapper.RegisterServices(container);
        }
    }

    public static class SimpleInjectorInitializerFactory
    {
        private static Container _container;

        public static void SetContainer(Container container)
        {
            _container = container;
        }

        public static T GetInstance<T>() where T : class
        {
            return _container.GetInstance<T>();
        }
    }
}
