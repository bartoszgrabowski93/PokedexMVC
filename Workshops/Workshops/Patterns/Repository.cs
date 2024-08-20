using Workshops.Models;

namespace Workshops.Patterns
{
    // TODO wymiana tego inferfejsu - na co? 
    public interface IConfiguration<in T> where T : class, IRepository {  }
    public record class StorageConfig(string ConnString, string Container) : IConfiguration<StorageRepository>
    {

    }

    public record class CosmosConfig(string ConnString, string Dbase, string Container) : IConfiguration<CosmosRepository>
    {
    

    }
       

    public interface IRepository
    {
        Task Save<T>(T input) where T : RepositoryObject;
        Task<T> Get<T>(Guid id) where T : RepositoryObject;
    }
    public class StorageRepository : IRepository
    {
        /* W przypadku chmury Azure Storage (repozytorium) - trzymamy tam pliki nieustrukturyzowane, np. backupy kwartalne, pliki których nie potrzeba cały czas
         * Potrzebne operacje do repozytorium - CRUDy,  */

        private readonly string connString;
        private readonly string container;

        public StorageRepository(string connString, string container) 
        {

        }
        public Task<T> Get<T>(Guid id) where T : RepositoryObject
        {
            throw new NotImplementedException();
        }

        public Task Save<T>(T input) where T : RepositoryObject
        {
            throw new NotImplementedException();
        }
    }
    public class CosmosRepository(string ConnString, string dbase, string container) : IRepository // primary constructor
    {
        public Task<T> Get<T>(Guid id) where T : RepositoryObject
        {
            throw new NotImplementedException();
        }

        public Task Save<T>(T input) where T : RepositoryObject
        {
            throw new NotImplementedException();
        }
    }
}
