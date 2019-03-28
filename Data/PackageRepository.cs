using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class PackageRepository : IPackageRepository
    {
        private readonly DataContext _context;
        public PackageRepository(DataContext context)
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

        public async Task<Package> GetPackage(int id)
        {
            var package = await _context.Package
                .FirstOrDefaultAsync(p => p.PackageID == id);

            return package;
        }

        public async Task<IEnumerable<Package>> GetPackages()
        {
            var packages = await _context.Package.ToListAsync();

            return packages;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}