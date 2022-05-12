using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        public IEnumerable<Event> _event = new Event[]
        {
            new Event()
            {
                EventId = 0,
                Title = "Dinamica Organizacional",
                Local = "São José do Rio Preto",
                Batch = "Lote 1",
                PeopleQuantity = 25,
                EventDate = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImageUrl = "imagem.jpg"
            },

            new Event()
            {
                EventId = 1,
                Title = "Operações com SQL Server",
                Local = "São Paulo",
                Batch = "Lote 2",
                PeopleQuantity = 250,
                EventDate = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImageUrl = "imagem1.jpg"
            }
        };
        public EventController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _event;
        }

        [HttpGet ("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _event.Where(events => events.EventId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de POST";
        }

        [HttpPut ("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de PUT com id = {id}";
        }

        [HttpDelete ("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de DELETE com id = {id}";
        }
    }
}
