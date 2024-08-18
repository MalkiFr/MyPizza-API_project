using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using My_pizza.Models;

namespace My_pizza.Interface{

 public interface Iworker :ILifeTime
  {
     
     List<Worker> Get();
     List<Worker> Delete(Worker w);

  }
}

