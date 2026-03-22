using Microsoft.Extensions.DependencyInjection;
using ProductManager.Data; 
using ProductManager.Services; 
using System;

namespace ProductManagerUI
{
    public static class Locator
    {
        private static IServiceProvider _serviceProvider;

        public static void Init()
        {
            var services = new ServiceCollection();

            //(Level 1: Repositories)
            services.AddSingleton<IDepositoryRepo, DepositoryRepo>();
            services.AddSingleton<IProductRepo, ProductRepo>();

            //(Level 2: Services) 
            services.AddSingleton<IDepositoryServices, DepositoryService>();

            _serviceProvider = services.BuildServiceProvider();
        }

        // Access point for ViewModels and pages 
        public static IDepositoryServices DepositoryService =>
            _serviceProvider.GetRequiredService<IDepositoryServices>();
    }
}