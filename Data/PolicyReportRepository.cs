using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class PolicyReportRepository : IPolicyReportRepository
    {
        private readonly DataContext _context;
        public PolicyReportRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<object>> GetPolicyReport(int gender, int packageID)
        {
            List<int> genderList = new List<int>();

            if (gender == 1)
            {
                genderList = new List<int>() {5,6, 7, 8, 9};
            } 
            else if (gender == 2) 
            {
                genderList = new List<int>() {0, 1,  2, 3, 4};
            }

            var report = await (from m in _context.MainMember
                where m.PackageID == packageID && genderList.Contains(int.Parse(m.IDNumber.Substring(6,1)))
                join p in _context.Package
                on m.PackageID equals p.PackageID
                select new {
                    PolicyNumber = m.PolicyNumber,
                    FullNames = m.FirstName + ' ' + m.Surname,
                    Title = m.Title,
                    IDNumber = m.IDNumber,
                    PackageName = p.PackageName,
                    PackagePrice = p.PackagePrice
                }).ToListAsync();

            return report;
        }
    }
}