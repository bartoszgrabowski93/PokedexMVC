using Microsoft.OpenApi.Models;

namespace Workshops.Patterns
{
    public static class Factory
    {
        public static T Create<T>(IConfiguration<T> config) where T: class, IRepository
        {
            switch(config)
            {
                case StorageConfig sc:
                    return new StorageRepository(sc.ConnString, sc.Container) as T;
                case CosmosConfig cc:
                    return new CosmosRepository(cc.ConnString, cc.Dbase, cc.Container) as T;
                 
            }

            return null; // według statystyk najczęstszy błąd, który występuje, ze względu na to że programiści nadużywają go, dlatego staramy się nie używać nulla jako wartość zwracana
            // throw new NotImplementedException();
        }
    }
}
