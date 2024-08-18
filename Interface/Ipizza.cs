using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using My_pizza.Models;

namespace My_pizza.Interface{

 public interface Ipizza:ILifeTime

 {
    List<Pizza> GetAll();
    Pizza? GetId(int id);
    void Add(Pizza pizza);
    void Delete(int id);
    ActionResult<Pizza> Update(Pizza pizza);

 }
 
}