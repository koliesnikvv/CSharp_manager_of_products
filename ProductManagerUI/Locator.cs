using Microsoft.Extensions.DependencyInjection;
using ProductManager.Data;
using ProductManager.Services;
using ProductManagerUI.ViewModels;
using System;

namespace ProductManagerUI
{
    public class Locator
    {
        private readonly IServiceProvider _serviceProvider;

        public Locator()
        {
            var services = new ServiceCollection();

            // 1. Реєструємо контекст бази даних
            services.AddDbContext<AppDbContext>();

            // 2. Реєструємо сервіс (Interface + Implementation)
            services.AddSingleton<IDepositoryService, ProductManager.Services.DepositoryService>();

            // 3. Реєструємо ViewModel для сторінок
            services.AddSingleton<MainViewModel>();

            // StorageDetailsViewModel створюємо як Transient, 
            // щоб він оновлювався при кожному відкритті сторінки складу
            services.AddTransient<StorageDetailsViewModel>();

            // ВАЖЛИВО: Будуємо провайдер, щоб він не був null
            _serviceProvider = services.BuildServiceProvider();
        }

        // Властивості для доступу з XAML або Code-behind
        public MainViewModel MainViewModel => _serviceProvider.GetRequiredService<MainViewModel>();

        public IDepositoryService DepositoryService => _serviceProvider.GetRequiredService<IDepositoryService>();

        // Метод для створення детальної в'юмоделі з параметром (Id складу)
        public StorageDetailsViewModel GetStorageDetailsViewModel(int id)
        {
            return new StorageDetailsViewModel(DepositoryService, id);
        }
    }
}