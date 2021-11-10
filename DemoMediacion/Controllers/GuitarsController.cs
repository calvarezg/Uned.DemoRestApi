using DemoMediacion.Data;
using DemoMediacion.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DemoMediacion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuitarsController : Controller
    {
        Repository repository;
       
        public GuitarsController(Repository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return Ok(repository.GetAll());
        }

        
        [HttpPost("{id}")]
        public ActionResult Create(Guitar guitar)
        {
            repository.Add(guitar);            
            return Created(nameof(Index), guitar);
        }
        
        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            var guitar = repository.Find(id);
            if (guitar == null)
                return NotFound();
            else
                return Ok(guitar);
        }

        [HttpPut("{id}")]
        public ActionResult Edit(int id, Guitar guitar)
        {
            if (id != guitar.Id)
                return BadRequest();
            else
            {
                repository.Update(guitar);
                return Ok(guitar);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok();
        }
    }
}
