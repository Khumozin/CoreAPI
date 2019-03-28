using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Data
{
    public interface IPolicyReportRepository
    {
         Task<IEnumerable<object>> GetPolicyReport(int gender, int packageID);
    }
}