using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
           
        }

        [HttpGet]
        public string Get()
        {
            return "value";
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo Put {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo Delete {id}";
        }
    }
}
