using Microsoft.AspNetCore.Mvc;
using My_pizza.Interface;
using My_pizza.Models;

namespace My_pizza.Controllers;
[ApiController]
[Route("[controller]")]

 public class WorkerController :ControllerBase
 {
     private readonly Iworker _workerService;
     public WorkerController(Iworker workerService)
      {
         _workerService=workerService;
         Console.WriteLine(_workerService.CreateDate);
      }

//מחזיר את מערך העובדים
    [HttpGet]
    [Route("[action]")]
     public List<Worker> GetAll()
     {
         return _workerService.Get();
     }

//מחיקת עובד מהמערך
    [HttpDelete]
     public List<Worker> delete(Worker w)
     {
        List<Worker>? result = _workerService.Delete(w);
            // if (result== null)
            //      return null;
        return result;   
     }

 }
