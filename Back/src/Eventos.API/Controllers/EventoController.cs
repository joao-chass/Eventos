using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
            {
               new Evento()
        {
            EventoId = 1,
                Tema = "Angular 11 e .net 5",
                Local = "S",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEnvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "fots"
               },
                new Evento()
        {
            EventoId = 2,
                Tema = "Angular 11 e .net 5",
                Local = "S",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEnvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "fots"
               }
    };
    public EventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
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
