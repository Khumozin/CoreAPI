using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DependantRepository : IDependantRepository
    {
        private readonly DataContext _context;
        public DependantRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteMulti(int id)
        {
            _context.Dependant.Where(d => d.MainMemberID == id)
                .ToList().ForEach(p => _context.Dependant.Remove(p));
        }

        public async Task<Dependant> GetDependant(int id)
        {
            var dependant = await _context.Dependant.FirstOrDefaultAsync(d => d.DependantID == id);

            return dependant;
        }

        public async Task<IEnumerable<Dependant>> GetDependants(int id)
        {
            var dependants = await _context.Dependant.Where(d => d.MainMemberID == id).ToListAsync();

            return dependants;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}