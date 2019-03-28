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
    public class PackageController : ControllerBase
    {
        private readonly IPackageRepository _repo;
        private readonly IMapper _mapper;
        public PackageController(IPackageRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetPackages()
        {
            var packagesFromRepo = await _repo.GetPackages();

            return Ok(packagesFromRepo);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPackage(int id)
        {
            var packageFromRepo = await _repo.GetPackage(id);

            return Ok(packageFromRepo);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Package package)
        {
            _repo.Add<Package>(package);
            await _repo.SaveAll();

            return Ok(package);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, PackageForUpdate packageForUpdate)
        {
            var packageFromRepo = await _repo.GetPackage(id);

            _mapper.Map(packageForUpdate, packageFromRepo);

            await _repo.SaveAll();

            return Ok(packageForUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var packageFromRepo = await _repo.GetPackage(id);
            _repo.Delete(packageFromRepo);

            await _repo.SaveAll();

            return Ok();
        }
    }
}