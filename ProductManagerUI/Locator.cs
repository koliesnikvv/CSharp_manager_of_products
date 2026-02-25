using ServicesClasses;
namespace ProductManagerUI
{
    public static class Locator
    {
        public static IDataService DataService
        { 
            get; private set; 
        }
        public static void Init()
        {
            IStorageInit storage = new StarterStorage();
            DataService = new ProcessingStorage(storage);
        }
    }
}
