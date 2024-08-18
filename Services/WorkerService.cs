using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using My_pizza.Interface;
using My_pizza.Models;

namespace My_pizza.Services;

public class workerService :Iworker
{

    public DateTime CreateDate {get; set;}
    List<Worker> workers { get; set;}

    public workerService()
    {
        workers=new List<Worker>
        {
           new Worker { Id=115, Name="Dani_Cahana"},
           new Worker { Id=116, Name="David_Shmuely"},
           new Worker { Id=201, Name="Moshe_Levi"},
           new Worker { Id=202, Name="Avraham_ziv"}
        };

         CreateDate=DateTime.Now;
    }
   
     public List<Worker> Get(){
          return workers;
    }


     public List<Worker?> Delete(Worker w)
    {
        
        if(w is null)
            return null;

        workers.Remove(w);
        return workers;

    }




}