using Microsoft.AspNetCore.Mvc;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        public EventController()
        {
            
        }

        [HttpGet]
        public string Get()
        {
            return "Exemplo de GET";
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
