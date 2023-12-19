using Microsoft.AspNetCore.Mvc;
using My_pizza.Models;

namespace My_pizza.Controllers;
[ApiController]
[Route("[controller]")]

public class PizzaController:ControllerBase
{
    // private static readonly List<Pizza> pizzot= new List<Pizza>()
    // {
    //     new Pizza(){ Id=1, Name="italiano", Gluten=true },
    //     new Pizza(){ Id=2, Name="pizza free", Gluten=false }
    // };

  [HttpGet]
  public List<Pizza> Get()
  {
      return pizzot;
  }


  [HttpGet]
  [Route("getName")]
  public String Getstring()
  {
      return "get";
  }

  [HttpGet("{id}")]
  public Pizza? GetById(int id)
  {
     foreach(var p in pizzot)
     {
        if( p.Id == id )
            return p;
     }
    
     return null;

  }
}
