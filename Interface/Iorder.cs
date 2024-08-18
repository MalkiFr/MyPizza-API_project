using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using My_pizza.Models;

namespace My_pizza.Interface{

 public interface Iorder:ILifeTime
 {
     public List<Order> Add(Order o);
 }


}