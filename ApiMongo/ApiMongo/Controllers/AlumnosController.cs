using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMongo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlumnosController : ControllerBase
    {
        public EscuelaServices _alumnosService;
        public AlumnosController(EscuelaServices alumnosServices)
        {
            _alumnosService = alumnosServices;
        }
        [HttpGet]
        public ActionResult<List<Alumnos>> Get()
        {
            return _alumnosService.Get();

        }
        [HttpPosst]
        public ActionResult<Alumnos> Create(Alumnos alumnos)
        {
            _alumnosService.Create(alumnos);
            return Ok(alumnos);

        }
        [HttpPut]
        public ActionResult Update(Alumnos alumnos)
        {
            _alumnosService.Update(alumnos.Id, alumnos);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _alumnosService.Delete(id);
            return ok();
        }
    }
}

