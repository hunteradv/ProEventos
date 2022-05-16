using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly Context context;
        public EventController(Context context)
        {
            this.context = context;

        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return context.Events;
        }

        [HttpGet("{id}")]
        public Event GetById(int id)
        {
            return context.Events.FirstOrDefault(events => events.EventId == id);
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
