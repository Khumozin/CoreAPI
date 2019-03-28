using System.Security.Claims;
using System.Threading.Tasks;
using API.Data;
using API.Dtos;
using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MainMemberController : ControllerBase
    {
        private readonly IMainMemberRepository _repo;
        private readonly IMapper _mapper;
        public MainMemberController(IMainMemberRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetMainMembers()
        {
            var mainMembers = await _repo.GetMainMembers();

            return Ok(mainMembers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMainMember(int id)
        {
            var mainMember = await _repo.GetMainMember(id);

            return Ok(mainMember);
        }

        [HttpPost]
        public async Task<IActionResult> Add(MainMember mainMember)
        {
            _repo.Add<MainMember>(mainMember);
            await _repo.SaveAll();

            return Ok(mainMember);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMainMember(int id, MainMemberForUpdate mainMemberForUpdate)
        {
            var mainmemberFromRepo = await _repo.GetMainMember(id);

            _mapper.Map(mainMemberForUpdate, mainmemberFromRepo);
            await _repo.SaveAll();
            
            return Ok(mainMemberForUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var memberFromRepo = await _repo.GetMainMember(id);
            _repo.Delete(memberFromRepo);

            await _repo.SaveAll();
            return Ok();
        }

    }
}