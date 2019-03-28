using System.Threading.Tasks;
using API.Data;
using API.Dtos;
using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IPolicyReportRepository _repo;
        public ReportController(IPolicyReportRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("{gender}/{packageID}")]
        public async Task<IActionResult> GetPolicyReport(int gender, int packageID)
        {
            var report = await _repo.GetPolicyReport(gender, packageID);

            return Ok(report);
        }
    }
}