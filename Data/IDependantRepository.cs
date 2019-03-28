using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Data
{
    public interface IDependantRepository
    {
         void Add<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         void DeleteMulti(int id);
         Task<Dependant> GetDependant(int id);
        Task<IEnumerable<Dependant>> GetDependants(int id);
        Task<bool> SaveAll();
    }
}