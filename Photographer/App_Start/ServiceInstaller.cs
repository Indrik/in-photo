using LightInject;

namespace Photographer
{
    public class ServiceInstaller
    {
        private readonly ServiceContainer container;

        public ServiceInstaller(ServiceContainer container)
        {
            this.container = container;
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
            container.RegisterControllers();
            container.EnableMvc();
        }
    }
}