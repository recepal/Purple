using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Purple.Api.Dtos;
using Purple.DAL;
using Purple.Model.Personnel;
using System.Threading.Tasks;

namespace Purple.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnelController : ControllerBase
    {
        private readonly PersonnelDbRepo _repo;
        private readonly IMapper _mapper;

        public PersonnelController(IMapper mapper)
        {
            _repo = new PersonnelDbRepo();
            _mapper = mapper;
        }

        [HttpPost("insert")]
        public async Task<ActionResult<bool>> Insert(PersonnelDto personnelDto)
        {
            Personnel personnel = _mapper.Map<Personnel>(personnelDto);

            bool result = await _repo.Insert(personnel);
            return result;

        }
    }
}
