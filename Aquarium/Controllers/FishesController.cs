using Aquarium.Managers;
using Aquarium.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aquarium.Controllers
{
    [Route("Fishes")]
    [ApiController]
    public class FishesController : Controller
    {
        private readonly FishesManager _manager = new FishesManager();

        // GET: api/<FishesController>
        [HttpGet]
        public IEnumerable<Fish> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<FishesController>/5
        [HttpGet("{id}")]
        public Fish Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<FishesController>
        [HttpPost]
        public Fish Post([FromBody] Fish value)
        {
            return _manager.Add(value);
        }

        // PUT api/<FishesController>/5
        [HttpPut("{id}")]
        public Fish Put(int id, [FromBody] Fish value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<FishesController>/5
        [HttpDelete("{id}")]
        public Fish Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
