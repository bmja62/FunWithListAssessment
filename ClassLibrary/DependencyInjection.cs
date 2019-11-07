using Microsoft.Extensions.DependencyInjection;

namespace ClassLibrary
{
    public class DependencyInjection
    {
        public static ServiceProvider Setup()
        {
            return new ServiceCollection().AddSingleton<IListService, ListService>().BuildServiceProvider();
        }
    }
}
