using System;
using System.Threading.Tasks;
using API.Data;
using API.Dtos;
using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DependantController : ControllerBase
    {
        private readonly IDependantRepository _repo;
        private readonly IMapper _mapper;
        public DependantController(IDependantRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet("dependants/{id}")]
        public async Task<IActionResult> GetDependants(int id)
        {
            var dependantsToReturn = await _repo.GetDependants(id);

            return Ok(dependantsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDependant(int id)
        {
            var dependantToReturn = await _repo.GetDependant(id);

            return Ok(dependantToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Dependant dependant)
        {
            _repo.Add<Dependant>(dependant);
            await _repo.SaveAll();

            return Ok(dependant);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, DependantForUpdate dependantForUpdate)
        {
            var dependantFromRepo = await _repo.GetDependant(id);

            _mapper.Map(dependantForUpdate, dependantFromRepo);

            await _repo.SaveAll();
            return Ok(dependantForUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var dependantFromRepo = await _repo.GetDependant(id);
            _repo.Delete(dependantFromRepo);

            await _repo.SaveAll();
            return Ok();
        }

        [HttpDelete("deteledMulti/{id}")]
        public async Task<IActionResult> DeleteMulti(int id)
        {

            _repo.DeleteMulti(id);

            await _repo.SaveAll();
            return Ok();
        }
    }
}