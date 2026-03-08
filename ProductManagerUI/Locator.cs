using Microsoft.Extensions.DependencyInjection;
using ServicesClasses;
using System;

namespace ProductManagerUI
{
    public static class Locator
    {
        private static IServiceProvider _serviceProvider;

        public static void Init()
        {
            var services = new ServiceCollection();

            // Register services according to DI principles
            services.AddSingleton<IStorageInit, StarterStorage>();
            services.AddSingleton<IDataService, ProcessingStorage>();

            _serviceProvider = services.BuildServiceProvider();
        }

        // Service access point for the UI
        public static IDataService DataService => _serviceProvider.GetRequiredService<IDataService>();
    }
}