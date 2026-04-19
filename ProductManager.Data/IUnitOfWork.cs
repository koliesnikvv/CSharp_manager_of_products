using System;

namespace ProductManager.Data
{
    // Інтерфейс визначає "контракт": що має вміти робити UnitOfWork
    public interface IUnitOfWork : IDisposable
    {
        IDepositoryRepo Depositaries { get; }
        IProductRepo Products { get; }

        int Save(); // Метод для збереження всіх змін у базу даних за один раз
    }
}