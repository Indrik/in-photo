using System;
using System.Reflection;
using LightInject;
using Photographer.Contract;

namespace Photographer
{
    public class ServiceInstaller
    {
        private readonly ServiceContainer _container;
        private readonly Func<ILifetime> _defaultLifetimeFactory;

        public ServiceInstaller()
        {
            _container = new ServiceContainer();
            _defaultLifetimeFactory = LifetimeFactory<PerScopeLifetime>;
        }

        private bool Initialized { get; set; }

        public void Initialize()
        {
            if (Initialized)
            {
                return;
            }

            RegisterBehaviour();
            Initialized = true;
        }

        private void RegisterBehaviour()
        {
            _container.RegisterControllers();
            _container.EnableMvc();

            Register<IWebHandler>(Assembly.Load("Photographer.Handlers"));
            Register<IService>(Assembly.Load("Photographer.Services"));
        }

        private void Register<T>(Assembly assembly, Func<ILifetime> lifetimeFactory = null)
        {
            Register(typeof(T), assembly, lifetimeFactory);
        }

        protected void Register(Type type, Assembly assembly, Func<ILifetime> lifetimeFactory = null)
        {
            lifetimeFactory = lifetimeFactory ?? _defaultLifetimeFactory;
            _container.RegisterAssembly(assembly, lifetimeFactory, (bt, t) => IsDerived(t, type));
        }

        private static ILifetime LifetimeFactory<T>() where T : ILifetime, new()
        {
            return new T();
        }

        private static bool IsDerived(Type type, Type baseType)
        {
            var isTypeImplementedFromInterface = baseType.IsInterface && type.GetInterface(baseType.Name) != null;
            return isTypeImplementedFromInterface || type.IsSubclassOf(baseType) || type.IsEquivalentTo(baseType);
        }
    }
}