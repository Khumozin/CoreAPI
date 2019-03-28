using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class MainMemberRepository : IMainMemberRepository
    {
        private readonly DataContext _context;
        public MainMemberRepository(DataContext context)
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

        public async Task<MainMember> GetMainMember(int id)
        {
            var mainMember = await _context.MainMember
                .FirstOrDefaultAsync(m => m.MainMemberID == id);

            return mainMember;
        }

        public async Task<IEnumerable<MainMember>> GetMainMembers()
        {
            var mainMembers = await _context.MainMember.ToListAsync();

            return mainMembers;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}