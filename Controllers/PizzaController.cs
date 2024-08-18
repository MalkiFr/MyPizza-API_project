using Microsoft.AspNetCore.Mvc;
using My_pizza.Models;
using My_pizza.Interface;

namespace My_pizza.Controllers;
[ApiController]
[Route("[controller]/[action]")]

public class PizzaController:ControllerBase
{
  
  private readonly Ipizza _pizzaService;
  public PizzaController(Ipizza pizzaService){

     _pizzaService=pizzaService;
     Console.WriteLine(_pizzaService.CreateDate);
  }


  [HttpGet]
  public List<Pizza> Get()
  {
      return _pizzaService.GetAll();
  }

//get
  [HttpGet]
  [Route("kkk/{id}")]
  public String Getstring(int id)
  {
      return "get"+id;
  }

  [HttpGet("{id}")]
  public Pizza? GetById(int id)
  {
    List<Pizza> pizzot=_pizzaService.GetAll();
     foreach(var p in pizzot)
     {
        if( p.Id == id )
            return p;
     }
    
     return null;

  }
  //create
  [HttpGet]
  [Route("n")]
  public string p(){
    return "kkkkllll";
  }

  //update
  [HttpPut]
  [Route("{pizza}")]
   public ActionResult<Pizza>  Update(Pizza pizza){
    return _pizzaService.Update(pizza);
  }
  //delete
  [HttpDelete]
   public void o(){
    
  }

    

}


    // private static readonly List<Pizza> pizzot= new List<Pizza>()
    // {
    //     new Pizza(){ Id=1, Name="italiano", Gluten=true },
    //     new Pizza(){ Id=2, Name="pizza free", Gluten=false }
    // };
