using System.Configuration;

namespace Photographer.Infrastructure
{
    public class ConfigurationHelper
    {
        public string Get(string property)
        {
            return ConfigurationManager.AppSettings[property];
        }
    }
}