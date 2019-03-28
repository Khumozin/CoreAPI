using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Data
{
    public interface IPackageRepository
    {
         void Add<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         Task<bool> SaveAll();
        Task<IEnumerable<Package>> GetPackages();
        Task<Package> GetPackage(int id);
    }
}