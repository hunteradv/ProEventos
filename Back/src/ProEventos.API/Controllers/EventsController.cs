using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Domain;
using ProEventos.Persistence;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly ProEventosContext ProEventosContext;
        public EventsController(ProEventosContext ProEventosContext)
        {
            this.ProEventosContext = ProEventosContext;

        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return ProEventosContext.Events;
        }

        [HttpGet("{id}")]
        public Event GetById(int id)
        {
            return ProEventosContext.Events.FirstOrDefault(events => events.Id == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de POST";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de PUT com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de DELETE com id = {id}";
        }
    }
}
