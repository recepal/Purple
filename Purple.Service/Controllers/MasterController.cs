using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Purple.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purple.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly MasterDbRepo _repo;

        public MasterController()
        {
            _repo = new MasterDbRepo();
        }

        [HttpGet("createDb")]
        public ActionResult CreateDb()
        {
            bool result = _repo.CreateDb();

            string message = result ? "Db oluşturuldu..." : "Db oluşturulamadı...";
            return Ok(message);
        }
    }
}
