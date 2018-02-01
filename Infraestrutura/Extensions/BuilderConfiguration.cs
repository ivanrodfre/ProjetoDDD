using Microsoft.Extensions.Configuration;
using System.IO;

namespace Infraestrutura.Extensions
{
    public class BuilderConfiguration
    {
        public static IConfigurationRoot AddConfigurationDirectory()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
