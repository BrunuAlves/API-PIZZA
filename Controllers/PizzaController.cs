using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();
    
    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id) => PizzaService.Get(id)!;

    // POST action
    [HttpPost]
    public void Add(Pizza pizza) => PizzaService.Add(pizza);

    // PUT action
    [HttpPut]
    public void Update(Pizza pizza) => PizzaService.Update(pizza);

    // DELETE action
    [HttpDelete("{id}")]
    public void Delete(int id) => PizzaService.Delete(id);
}