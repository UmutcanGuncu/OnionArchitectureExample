using System;
using System.Configuration;
using Microsoft.Extensions.Configuration;
namespace OnionArchitectureExample.Persistence
{
	public static class Configurations
	{
      public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/OnionArchitectureExample.Presentation"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("DefaultConnection");
            }
        }
    }
}

